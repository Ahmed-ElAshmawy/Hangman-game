using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Client
{
    public partial class Form1 : Form
    {
        TcpClient client;
        public BinaryReader br;
        public BinaryWriter bw;
        NetworkStream nStream;
        Thread thread;
        string[] info;
        string stw = "";
        delegate void voiddel();
        delegate void labledel();
        NewRoom r;
        string roominfo = "";
        string word = "";
        List<Label> lables = new List<Label>();
        List<Button> btns = new List<Button>();
        char[] char_arr;
        int count = 0;
        int between;
        int watch = 0;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            panel_intro.Visible = false;

        }
        private void ConDiscon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Client_name.Text))
            {
                MessageBox.Show("must enter name");
                return;
            }
            client = new TcpClient();
            try
            {
                client.Connect(new IPAddress(new byte[] { 127, 0, 0, 1 }), 20000);

            }
            catch
            {

                MessageBox.Show("server is offline");
            }

            //enabe btns
            button3.Enabled = true;
            button4.Enabled = true;
            button1.Enabled = true;

            nStream = client.GetStream();
            br = new BinaryReader(nStream);
            bw = new BinaryWriter(nStream);
            thread = new Thread(new ThreadStart(read));
            thread.Start();
            StatusLabel.BackColor = Color.Green;
            ConDiscon.Visible = false;
            Close.Visible = true;
            bw.Write(Client_name.Text);
        }
        void read()
        {
            try
            {
                while (true)
                {
                    string str = br.ReadString();
                    if (str.Contains(','))
                    {
                        info = str.Split(',');
                        for (int i = 0; i < listView1.Items.Count; i++)
                        {
                            if (listView1.Items[i].SubItems[0].Text == info[0])
                                listView1.Items.Remove(listView1.Items[i]);

                        }
                        ListViewItem itm = new ListViewItem(info);
                        listView1.Items.Add(itm);
                    }
                    else if (str.Contains("$Start"))
                    {
                        stw = str.Split('+')[1];
                        showgame();
                    }
                    else if (str.Contains("$Request"))
                    {
                        if (MessageBox.Show("Player " + str.Split('-')[1] + " wants to join", "Request Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            bw.Write("Accepted," + Client_name.Text + "," + str.Split('-')[1] + "," + word);
                            panel_intro.Enabled = true;
                        }
                    }
                    else if (str.Contains("$off"))
                    {
                        panel_intro.Enabled = false;
                    }
                    else if (str.Contains("$on"))
                    {
                        panel_intro.Enabled = true;
                    }
                    else if (str.Contains("$new"))
                    {
                        word = str.Split('-')[1];
                        word = word.ToLower();
                        char_arr = word.ToCharArray();
                        between = 200 / char_arr.Length;
                        showlable();
                    }
                    else if (str.Contains("$newgameword"))
                    {
                        word = str.Split('-')[1];
                    }
                    else if (str.Contains("$watchers"))
                    {
                        word = str.Split('-')[1];
                        word = word.ToLower();
                        char_arr = word.ToCharArray();
                        between = 200 / char_arr.Length;
                        showlable();

                    }
                    else if (str.Contains("$Canceled"))
                    {
                        panel_intro.Visible = false;
                    }
                    else
                    {
                        groupBox_Char.Controls.Cast<Control>().Where(x => x.Text == str.Split('-')[0].ToUpper()).First().Enabled = false;
                        btns.Add((Button)groupBox_Char.Controls.Cast<Control>().Where(x => x.Text == str.Split('-')[0].ToUpper()).First());
                        check(str.Split('-')[0].ToCharArray()[0], str.Split('-')[1]);
                        ChatBox.Items.Add(str);
                    }
                }
            }
            catch
            {
                StatusLabel.BackColor = Color.Red;
                Close.Visible = false;
                ConDiscon.Visible = true;
            }
        }

        public void showgame()
        {
            if (this.InvokeRequired)
            {
                voiddel d = new voiddel(showgame);
                this.Invoke(d);
            }
            else
            {
                panel_intro.Visible = true;
                panel_intro.Enabled = false;
                word = stw;
                char_arr = word.ToCharArray();
                between = 200 / char_arr.Length;
                Makelable();
            }
        }

        public void showlable()
        {
            if (this.InvokeRequired)
            {
                labledel d = new labledel(showlable);
                this.Invoke(d);
            }
            else
            {
                Makelable();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //show & hide buttons
            StatusLabel.BackColor = Color.Red;
            ConDiscon.Visible = true;
            Close.Visible = false;
            bw.Write("Disconnected,"+Client_name.Text);
            //close conntion 
            client.Close();
            thread.Abort();
            br.Close();
            nStream.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread?.Abort();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            r = new NewRoom();
            if (r.ShowDialog() == DialogResult.OK && r.Room_name != "")
            {
                roominfo = r.Room_name;
                bw.Write("$" + "," + Client_name.Text + "," + r.Room_name + "," + r.Room_level + "," + r.Room_categ);
                panel_intro.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Enter Room Name to Create");
                panel_intro.Visible = false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems != null && Client_name.Text != listView1.SelectedItems[0].SubItems[1].Text && int.Parse(listView1.SelectedItems[0].SubItems[3].Text) == 1)
            {
                roominfo = listView1.SelectedItems[0].SubItems[0].Text;
                bw.Write("JOIN" + "," + listView1.SelectedItems[0].SubItems[0].Text + "," + Client_name.Text);
            }
        }
        void Makelable()
        {
            for (int i = 0; i < char_arr.Length; i++)
            {
                lables.Add(new Label());
                lables[i].Location = new Point((i * between) + 20, 70);
                if (char_arr[i].ToString() == " ")
                    lables[i].Text = " ";
                else
                {
                    lables[i].Text = "__";
                    lables[i].Parent = groupBox_Word;
                    lables[i].BringToFront();
                    lables[i].CreateControl();
                }
            }
            label_Lenght.Text = "Word Length: " + char_arr.Length.ToString();
        }
        void Reset()
        {
            Makelable();
            labe_missed.Text = "";
            foreach (Button item in btns)
            {
                item.Enabled = true;
            }
            count = 0;
        }
        private void button28_MouseClick(object sender, MouseEventArgs e)
        {
            ((Button)sender).Enabled = false;
            btns.Add((Button)sender);
            char letter = ((Button)sender).Text.ToLower().ToCharArray()[0];
            bw.Write("@Send," + roominfo + "," + Client_name.Text + "," + letter.ToString());
            check(letter, Client_name.Text);
        }
        void check(char letter, string name)
        {
            if (word.Contains(letter))
            {
                if (Client_name.Text == name)
                { bw.Write("@Same," + roominfo + "," + Client_name.Text); }
                for (int i = 0; i < char_arr.Length; i++)
                {
                    if (char_arr[i] == letter)
                    {
                        lables[i].Text = letter.ToString();
                    }
                }

                foreach (Label l in lables)
                    if (l.Text == "__") return;

                if (Client_name.Text == name && watch == 0)
                {
                    if (MessageBox.Show("Congratulations " + name + " You Win do u want to play again", "Congrat Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        bw.Write("OK," + roominfo + "," + Client_name.Text+",WIN");
                        Reset();
                    }
                    else
                    {
                        bw.Write("Cancel," + roominfo + "," + Client_name.Text + ",WIN");
                        if (Client_name.Text != info[1])
                            panel_intro.Visible = false;
                    }

                }
                else
                {
                    if(watch == 0)
                    {
                        if (MessageBox.Show("Hard Luck " + Client_name.Text + " You lose do u want to play again", "Congrat Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            bw.Write("OK," + roominfo + "," + Client_name.Text+ ",Lose");
                            Reset();
                        }
                        else
                        {
                            if (Client_name.Text != info[1])
                                panel_intro.Visible = false;
                        }
                    }
                }
            }
            else
            {
                if (Client_name.Text == name && watch == 0)
                {
                    bw.Write("@Change," + roominfo + "," + Client_name.Text);
                    count++;
                    labe_missed.Text = "Missing Numbers: " + (count).ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems != null && Client_name.Text != listView1.SelectedItems[0].SubItems[1].Text && Client_name.Text != listView1.SelectedItems[0].SubItems[2].Text && int.Parse(listView1.SelectedItems[0].SubItems[3].Text) == 2)
            {
                watch = 1;
                bw.Write("Watch" + "," + listView1.SelectedItems[0].SubItems[0].Text + "," + Client_name.Text);
                panel_intro.Visible = true;
                panel_intro.Enabled = false;
            }
            else
                MessageBox.Show("Choose Suitable Name");
        }
    }
}

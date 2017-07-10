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

namespace Servier
{
    public partial class Form1 : Form
    {
        TcpListener server;
        List<Client> myClients;
        Thread thread;
        List<Room> myRooms;
        Client c, w;
        public delegate void client_connected();
        string ranword = "";
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            myClients = new List<Client>();
            myRooms = new List<Room>();
            server = new TcpListener(new IPAddress(new byte[] { 127, 0, 0, 1 }), 20000);
            server.Start();
            thread = new Thread(new ThreadStart(NewClient));
            thread.Start();
        }
        void NewClient()
        {
            try
            {
                while (true)
                {
                    Client client = new Client(server.AcceptSocket(), ChatBox);
                    client.onrecieve += Client_onrecieve;
                    myClients.Add(client);
                    ClientList.Items.Add(client.Name);

                    if (myClients.Count > 0)
                    {
                        StatusLabel.BackColor = Color.Green;
                        client_connected Ccon = new client_connected(client_connected_fun);
                        Ccon();
                    }

                    else
                        StatusLabel.BackColor = Color.Red;

                }
            }
            catch { MessageBox.Show("Error Client"); }
        }

        void client_connected_fun()
        {
            if (listBox_rooms.Items.Count != 0)
            {
                for (int i = 0; i < myRooms.Count; i++)
                    myClients.Last().Write(myRooms[i].Room_name + "," + myRooms[i].player1.Name + "," + myRooms[i].player2.Name + "," + myRooms[i].count.ToString()+","+ myRooms[i].room_lev+","+ myRooms[i].room_cat);
            }
        }
        private void Client_onrecieve(object sender, EventArgs e)
        {
            string[] info = ChatBox.Items[ChatBox.Items.Count - 1].ToString().Split(',');
            Room r;
            if (info[0] == "$")
            {
                ranword = RandomWord(info[3], info[4]);
                for (int i = 0; i < myClients.Count; i++)
                {
                    if (myClients[i].Name == info[1])
                    {
                        r = new Room(myClients[i], info[2], info[3], info[4]);
                        myRooms.Add(r);
                        listBox_rooms.Items.Add(info[2]);
                        r.clients_rooms.Add(info[1], info[2]);
                        myClients[i].Write("$new-" + ranword);
                        break;
                    }

                }
                foreach (Client item in myClients)
                    item.Write(myRooms.Last().Room_name + "," + myRooms.Last().player1.Name + "," + myRooms.Last().player2.Name + "," + myRooms.Last().count.ToString()+","+ myRooms.Last().room_lev+","+ myRooms.Last().room_cat);
            }
            else if (info[0] == "JOIN")
            {
                for (int i = 0; i < myRooms.Count; i++)
                {
                    if (myRooms[i].Room_name == info[1])
                    {
                        myRooms[i].player1.Write("$Request-" + info[2]);
                        break;
                    }
                }
            }
            else if (info[0] == "Accepted")
            {

                for (int i = 0; i < myClients.Count; i++)
                {
                    if (myClients[i].Name == info[2])
                    {
                        myClients[i].Write("$Start+" + info[3]);
                        c = myClients[i];
                        break;
                    }
                }
                for (int i = 0; i < myRooms.Count; i++)
                {
                    if (myRooms[i].player1.Name == info[1])
                    {
                        myRooms[i].join(c);
                        break;
                    }
                }
                foreach (Client item in myClients)
                    item.Write(myRooms.Last().Room_name + "," + myRooms.Last().player1.Name + "," + myRooms.Last().player2.Name + "," + myRooms.Last().count.ToString()+","+ myRooms.Last().room_lev+","+ myRooms.Last().room_cat);
            }
            else if (info[0] == "@Send")
            {
                for (int i = 0; i < myRooms.Count; i++)
                {
                    if (myRooms[i].Room_name == info[1])
                    {
                        if (myRooms[i].player1.Name == info[2])
                        {
                            myRooms[i].player2.Write(info[3] + "-" + info[2]);
                        }
                        else
                        {
                            myRooms[i].player1.Write(info[3] + "-" + info[2]);
                        }
                        foreach (Client item in myRooms[i].watchers)
                        {
                            item.Write(info[3] + "-" + info[2]);
                        }
                    }
                }
            }
            else if (info[0] == "@Same")
            {
                for (int i = 0; i < myRooms.Count; i++)
                {
                    if (myRooms[i].Room_name == info[1])
                    {
                        if (myRooms[i].player1.Name == info[2])
                        {
                            myRooms[i].player2.Write("$off");
                            myRooms[i].player1.Write("$on");
                            break;
                        }
                        else
                        {
                            myRooms[i].player1.Write("$off");
                            myRooms[i].player2.Write("$on");
                            break;
                        }
                    }
                }
            }

            else if (info[0] == "@Change")
            {
                for (int i = 0; i < myRooms.Count; i++)
                {
                    if (myRooms[i].Room_name == info[1])
                    {
                        if (myRooms[i].player1.Name == info[2])
                        {
                            myRooms[i].player2.Write("$on");
                            myRooms[i].player1.Write("$off");
                            break;
                        }
                        else
                        {
                            myRooms[i].player1.Write("$on");
                            myRooms[i].player2.Write("$off");
                            break;
                        }
                    }
                }
            }
            else if (info[0] == "OK" || info[0] == "Cancel")
            {
                for (int i = 0; i < myRooms.Count; i++)
                {
                    if (myRooms[i].Room_name == info[1])
                    {
                        if (myRooms[i].player1.Name == info[2])
                        {
                            myRooms[i].player1state = 1;
                            if (info[0] == "Cancel")
                                myRooms[i].player2.Write("$Canceled");
                            if (info[3] == "WIN")
                            {
                                myRooms[i].p1score++;
                                writefile(myRooms);
                            }
                        }
                        else if (myRooms[i].player2.Name == info[2])
                        {
                            myRooms[i].player2state = 1;
                            if (info[3] == "WIN")
                            {
                                myRooms[i].p2score++;
                                writefile(myRooms);
                            }
                        }
                        if (myRooms[i].player1state == myRooms[i].player2state)
                        {
                            ranword = RandomWord(myRooms[i].room_lev, myRooms[i].room_cat);
                            myRooms[i].player1.Write("$newgameword-" + ranword);
                            myRooms[i].player2.Write("$newgameword-" + ranword);
                            myRooms[i].player1state = 0;
                            myRooms[i].player2state = 0;
                            if (myRooms[i].watchers != null)
                            {
                                foreach (Client item in myRooms[i].watchers)
                                {
                                    item.Write("$newgameword-" + ranword);
                                }
                            }
                        }
                    }
                }
            }
            else if (info[0] == "Watch")
            {
                for (int i = 0; i < myClients.Count; i++)
                {
                    if (myClients[i].Name == info[2])
                    {
                        w = myClients[i];
                        break;
                    }
                }

                for (int i = 0; i < myRooms.Count; i++)
                {
                    if (myRooms[i].Room_name == info[1])
                    {
                        myRooms[i].watchers.Add(w);
                        foreach (Client item in myRooms[i].watchers)
                        {
                            item.Write("$watchers-" + ranword);
                        }
                        break;
                    }
                }

            }
            else if (info[0] == "Disconnected")
            {
                foreach (Client item in myClients)
                {
                    if (item.Name == info[1])
                    {
                        ClientList.Items.Remove(item.Name);
                        myClients.Remove(item);

                        return;
                    }
                }
            }
        }

        void writefile(List<Room> r)
        {
            StreamWriter writer = File.CreateText("reminders.txt");
            writer.WriteLine("Welcome to Score Files");
            for (int i = 0; i < r.Count; i++)
            {
                writer.WriteLine(r[i].player1.Name + " Score= " + r[i].p1score.ToString() + ", " + r[i].player2.Name + " Score= " + r[i].p2score.ToString());
                writer.Write("**********************************************************************");
            }
            writer.Write(writer.NewLine);
            writer.Close();
            Console.ReadLine();
        }
        string RandomWord(string level, string catog)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CSharp;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "get_keyword";
            SqlParameter p1 = new SqlParameter("@level", level);
            SqlParameter p2 = new SqlParameter("@cat", catog);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Connection = con;
            con.Open();
            string words = cmd.ExecuteScalar().ToString();
            con.Close();
            return words;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread?.Abort();
        }
    }
    public class Client
    {
        public Socket myScoket { get; set; }
        public string Name { get; set; }
        BinaryReader br;
        ListBox ChatBox;
        NetworkStream nStream;
        Thread thread;
        BinaryWriter bw;
        public event EventHandler onrecieve;
        public Client()
        { }
        public Client(Socket s, ListBox box)
        {
            myScoket = s;
            nStream = new NetworkStream(s);
            bw = new BinaryWriter(nStream);
            br = new BinaryReader(nStream);
            thread = new Thread(new ThreadStart(Read));
            thread.Start();
            ChatBox = box;
            Name = br.ReadString();
        }
        public void Read()
        {
            try
            {
                while (true)
                {
                    {
                        if (nStream.DataAvailable)
                        {
                            ChatBox.Items.Add(br.ReadString());
                            onrecieve(this, new EventArgs());
                        }
                    }
                }
            }
            catch
            {
                myScoket.Close();
                nStream.Close();
            }
        }
        public void Write(string s)
        {
            try
            {
                {
                    bw.Write(s);
                    ChatBox.Items.Clear();
                    ChatBox.Items.Add(s);
                }
            }
            catch
            {
                bw.Close();
            }

        }
    }
    class Room
    {
        public Client player1 { get; set; }
        public Client player2 { get; set; }
        public List<Client> watchers;
        public Dictionary<string, string> clients_rooms = new Dictionary<string, string>();
        public string room_lev { get; set; }
        public string room_cat { get; set; }
        public int player1state { get; set; }
        public int player2state { get; set; }
        public int p1score { get; set; }
        public int p2score { get; set; }
        public int count { get; set; }
        public string Room_name { get; set; }
        public Room(Client creat, string room_name, string level, string catog)
        {
            player1 = creat;
            Room_name = room_name;
            room_lev = level;
            room_cat = catog;
            count = 1;
            watchers = new List<Client>();
            player2 = new Client();
            player2.Name = "N/A";
            player1state = 0;
            player2state = 0;
            p1score = 0;
            p2score = 0;
        }
        public void join(Client player)
        {
            player2 = player;
            count = 2;
        }
    }
}

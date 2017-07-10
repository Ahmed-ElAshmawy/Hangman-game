namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StatusLabel = new System.Windows.Forms.TextBox();
            this.ChatBox = new System.Windows.Forms.ListBox();
            this.ConDiscon = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Client_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.labe_missed = new System.Windows.Forms.Label();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label_Lenght = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.groupBox_Char = new System.Windows.Forms.GroupBox();
            this.button32 = new System.Windows.Forms.Button();
            this.groupBox_Word = new System.Windows.Forms.GroupBox();
            this.panel_intro = new System.Windows.Forms.Panel();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_Char.SuspendLayout();
            this.groupBox_Word.SuspendLayout();
            this.panel_intro.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Red;
            this.StatusLabel.Location = new System.Drawing.Point(185, 10);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.ReadOnly = true;
            this.StatusLabel.Size = new System.Drawing.Size(34, 20);
            this.StatusLabel.TabIndex = 7;
            // 
            // ChatBox
            // 
            this.ChatBox.FormattingEnabled = true;
            this.ChatBox.Location = new System.Drawing.Point(12, 37);
            this.ChatBox.MultiColumn = true;
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(184, 43);
            this.ChatBox.TabIndex = 4;
            // 
            // ConDiscon
            // 
            this.ConDiscon.Location = new System.Drawing.Point(125, 124);
            this.ConDiscon.Name = "ConDiscon";
            this.ConDiscon.Size = new System.Drawing.Size(63, 23);
            this.ConDiscon.TabIndex = 8;
            this.ConDiscon.Text = "Connect";
            this.ConDiscon.UseVisualStyleBackColor = true;
            this.ConDiscon.Click += new System.EventHandler(this.ConDiscon_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(104, 8);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 9;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Visible = false;
            this.Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // Client_name
            // 
            this.Client_name.Location = new System.Drawing.Point(12, 124);
            this.Client_name.Name = "Client_name";
            this.Client_name.Size = new System.Drawing.Size(100, 20);
            this.Client_name.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Create Room";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter Name";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Location = new System.Drawing.Point(248, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(479, 107);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Room Name";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Creator Name";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Player 2";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Player No";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(227, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Join";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(128, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Watch";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // labe_missed
            // 
            this.labe_missed.AutoSize = true;
            this.labe_missed.Location = new System.Drawing.Point(501, 293);
            this.labe_missed.Name = "labe_missed";
            this.labe_missed.Size = new System.Drawing.Size(35, 13);
            this.labe_missed.TabIndex = 38;
            this.labe_missed.Text = "label1";
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(368, 45);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(27, 23);
            this.button28.TabIndex = 29;
            this.button28.Text = "Z";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(335, 45);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(27, 23);
            this.button27.TabIndex = 28;
            this.button27.Text = "Y";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(302, 45);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(27, 23);
            this.button26.TabIndex = 27;
            this.button26.Text = "X";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(269, 45);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(27, 23);
            this.button25.TabIndex = 26;
            this.button25.Text = "W";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(236, 45);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(27, 23);
            this.button24.TabIndex = 25;
            this.button24.Text = "V";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(203, 45);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(27, 23);
            this.button23.TabIndex = 24;
            this.button23.Text = "U";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(170, 45);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(27, 23);
            this.button22.TabIndex = 23;
            this.button22.Text = "T";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(137, 45);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(27, 23);
            this.button21.TabIndex = 22;
            this.button21.Text = "S";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(104, 45);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(27, 23);
            this.button20.TabIndex = 21;
            this.button20.Text = "R";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(72, 45);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(27, 23);
            this.button19.TabIndex = 20;
            this.button19.Text = "Q";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(39, 45);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(27, 23);
            this.button18.TabIndex = 19;
            this.button18.Text = "P";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(6, 45);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(27, 23);
            this.button17.TabIndex = 18;
            this.button17.Text = "O";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(433, 16);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(27, 23);
            this.button16.TabIndex = 17;
            this.button16.Text = "N";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(401, 16);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(27, 23);
            this.button15.TabIndex = 16;
            this.button15.Text = "M";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(368, 16);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(27, 23);
            this.button14.TabIndex = 15;
            this.button14.Text = "L";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(335, 16);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(27, 23);
            this.button13.TabIndex = 14;
            this.button13.Text = "K";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // label_Lenght
            // 
            this.label_Lenght.AutoSize = true;
            this.label_Lenght.Location = new System.Drawing.Point(360, 126);
            this.label_Lenght.Name = "label_Lenght";
            this.label_Lenght.Size = new System.Drawing.Size(69, 13);
            this.label_Lenght.TabIndex = 0;
            this.label_Lenght.Text = "Work Length";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(302, 16);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(27, 23);
            this.button12.TabIndex = 13;
            this.button12.Text = "J";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(269, 16);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(27, 23);
            this.button11.TabIndex = 12;
            this.button11.Text = "I";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(203, 16);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(27, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "G";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(170, 16);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(27, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "F";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(137, 16);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(27, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "E";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(104, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(27, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "D";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(71, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(27, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "C";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(36, 16);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(27, 23);
            this.button10.TabIndex = 5;
            this.button10.Text = "B";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(3, 16);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(27, 23);
            this.button29.TabIndex = 4;
            this.button29.Text = "A";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // groupBox_Char
            // 
            this.groupBox_Char.Controls.Add(this.button28);
            this.groupBox_Char.Controls.Add(this.button27);
            this.groupBox_Char.Controls.Add(this.button26);
            this.groupBox_Char.Controls.Add(this.button25);
            this.groupBox_Char.Controls.Add(this.button24);
            this.groupBox_Char.Controls.Add(this.button23);
            this.groupBox_Char.Controls.Add(this.button22);
            this.groupBox_Char.Controls.Add(this.button21);
            this.groupBox_Char.Controls.Add(this.button20);
            this.groupBox_Char.Controls.Add(this.button19);
            this.groupBox_Char.Controls.Add(this.button18);
            this.groupBox_Char.Controls.Add(this.button17);
            this.groupBox_Char.Controls.Add(this.button16);
            this.groupBox_Char.Controls.Add(this.button15);
            this.groupBox_Char.Controls.Add(this.button14);
            this.groupBox_Char.Controls.Add(this.button13);
            this.groupBox_Char.Controls.Add(this.button12);
            this.groupBox_Char.Controls.Add(this.button11);
            this.groupBox_Char.Controls.Add(this.button32);
            this.groupBox_Char.Controls.Add(this.button9);
            this.groupBox_Char.Controls.Add(this.button8);
            this.groupBox_Char.Controls.Add(this.button7);
            this.groupBox_Char.Controls.Add(this.button6);
            this.groupBox_Char.Controls.Add(this.button5);
            this.groupBox_Char.Controls.Add(this.button10);
            this.groupBox_Char.Controls.Add(this.button29);
            this.groupBox_Char.Location = new System.Drawing.Point(12, 180);
            this.groupBox_Char.Name = "groupBox_Char";
            this.groupBox_Char.Size = new System.Drawing.Size(466, 126);
            this.groupBox_Char.TabIndex = 37;
            this.groupBox_Char.TabStop = false;
            this.groupBox_Char.Text = "CharBox";
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(236, 16);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(27, 23);
            this.button32.TabIndex = 11;
            this.button32.Text = "H";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button28_MouseClick);
            // 
            // groupBox_Word
            // 
            this.groupBox_Word.Controls.Add(this.label_Lenght);
            this.groupBox_Word.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Word.Name = "groupBox_Word";
            this.groupBox_Word.Size = new System.Drawing.Size(456, 145);
            this.groupBox_Word.TabIndex = 36;
            this.groupBox_Word.TabStop = false;
            this.groupBox_Word.Text = "WordBox";
            // 
            // panel_intro
            // 
            this.panel_intro.BackColor = System.Drawing.SystemColors.Control;
            this.panel_intro.Controls.Add(this.groupBox_Char);
            this.panel_intro.Controls.Add(this.labe_missed);
            this.panel_intro.Controls.Add(this.groupBox_Word);
            this.panel_intro.Location = new System.Drawing.Point(0, 201);
            this.panel_intro.Name = "panel_intro";
            this.panel_intro.Size = new System.Drawing.Size(739, 323);
            this.panel_intro.TabIndex = 36;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Room Level";
            this.columnHeader5.Width = 84;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Room Category";
            this.columnHeader6.Width = 92;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 541);
            this.Controls.Add(this.panel_intro);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Client_name);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.ConDiscon);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ChatBox);
            this.Name = "Form1";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox_Char.ResumeLayout(false);
            this.groupBox_Word.ResumeLayout(false);
            this.groupBox_Word.PerformLayout();
            this.panel_intro.ResumeLayout(false);
            this.panel_intro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StatusLabel;
        private System.Windows.Forms.ListBox ChatBox;
        private System.Windows.Forms.Button ConDiscon;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.TextBox Client_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labe_missed;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label_Lenght;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.GroupBox groupBox_Char;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.GroupBox groupBox_Word;
        private System.Windows.Forms.Panel panel_intro;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}


namespace Servier
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
            this.ChatBox = new System.Windows.Forms.ListBox();
            this.StatusLabel = new System.Windows.Forms.TextBox();
            this.ClientList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_rooms = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChatBox
            // 
            this.ChatBox.FormattingEnabled = true;
            this.ChatBox.Location = new System.Drawing.Point(12, 35);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(107, 95);
            this.ChatBox.TabIndex = 0;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Red;
            this.StatusLabel.Location = new System.Drawing.Point(12, 9);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.ReadOnly = true;
            this.StatusLabel.Size = new System.Drawing.Size(34, 20);
            this.StatusLabel.TabIndex = 3;
            // 
            // ClientList
            // 
            this.ClientList.FormattingEnabled = true;
            this.ClientList.Location = new System.Drawing.Point(166, 35);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(107, 147);
            this.ClientList.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Online Clients Names";
            // 
            // listBox_rooms
            // 
            this.listBox_rooms.FormattingEnabled = true;
            this.listBox_rooms.Location = new System.Drawing.Point(286, 35);
            this.listBox_rooms.Name = "listBox_rooms";
            this.listBox_rooms.Size = new System.Drawing.Size(107, 147);
            this.listBox_rooms.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rooms";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 204);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_rooms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientList);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ChatBox);
            this.Name = "Form1";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ChatBox;
        private System.Windows.Forms.TextBox StatusLabel;
        private System.Windows.Forms.ListBox ClientList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_rooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}


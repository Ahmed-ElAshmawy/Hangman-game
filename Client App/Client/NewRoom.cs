using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{


    public partial class NewRoom : Form
    {
        public string Room_name
        {
            set
            {
                textBox_name.Text = value;
            }
            get
            {
                return textBox_name.Text;
            }
        }
        public string Room_level {

            set
            {
                comboBox_level.SelectedItem = value;
            }
            get
            {
                return comboBox_level.SelectedItem.ToString();
            }


        }
        public string Room_categ {

            set
            {
                comboBox_Cat.SelectedItem = value;
            }
            get
            {
                return comboBox_Cat.SelectedItem.ToString();
            }

        }
        public NewRoom()
        {
            InitializeComponent();
            comboBox_level.SelectedIndex = 0;
            comboBox_Cat.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}

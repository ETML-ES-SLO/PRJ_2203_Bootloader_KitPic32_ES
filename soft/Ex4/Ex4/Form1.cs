using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            cboPortNames.Items.AddRange(ports);
            cboPortNames.SelectedIndex = 0;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtOuput_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            //Quitte l'application
            Application.Exit();
        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

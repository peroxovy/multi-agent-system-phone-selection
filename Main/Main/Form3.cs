using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form3 : Form
    {

        public Form3(string phone, string price, string lp, string agentid)
        {
            InitializeComponent();
            textBox1.Text = phone;
            textBox2.Text = price+" zł";
            textBox3.Text = lp;
            textBox4.Text = "Agent numer " + agentid;
            this.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Zakupiono telefon! Został dodany do bazy wiedzy.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message);
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                /*
                 *  Tutaj dodam telefon do bazy wiedzy
                 */ 

                Application.Restart();
            }
        }
    }
}

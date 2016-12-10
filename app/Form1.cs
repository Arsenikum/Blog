using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void SendOnMail(string category)
        {
            /*
             * Send on email
            */
        }

        private void SaveInDatabase(string category)
        {
            /*
             * Query to database (INSERT)
            */
        }

        private bool TryGetCategory(string category)
        {
            /*
             * Query to database (SELECT)
            */
            return false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                var result = TryGetCategory(textBox1.Text);

                if (!result)
                {
                    SaveInDatabase(textBox1.Text);
                    SendOnMail(textBox1.Text);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox2.Text))
            {
                SendOnMail(richTextBox2.Text);
            }
        }
    }
}

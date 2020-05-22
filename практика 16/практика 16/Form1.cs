using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика_16
{
    public partial class Form1 : Form
    {
        Class1 x1;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonDo_Click(object sender, EventArgs e)
        {
            if (Input.Text != "input: " && Input.Text != "")
            {
                x1 = new Class1(Input.Text);
                int[] x2 = new int [1];
                if (rb2.Checked == true)
                {
                    x2 = x1.ConvertTo2();
                }
                if(rb8.Checked == true)
                {
                    x2 = x1.ConvertTo8();
                }
                if(rb16.Checked == true)
                {
                    x2 = x1.ConvertTo16();
                }
                for (int i = 0; i < x1.length; i++)
                {
                    Output.Text = Output.Text + " " + x2[i];
                }
            }
            else Output.Text = "Вы не ввели число. Нажмите OK";
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Input.Text = "input: ";
            Output.Text = "output: ";
            rb2.Checked = true;
        }
    }
}

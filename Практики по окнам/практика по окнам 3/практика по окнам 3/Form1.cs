using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика_по_окнам_3
{
    public partial class Form1 : Form
    {
        private int i;
        public Form1()
        {
            InitializeComponent();
            i = 1;
            button1.Text = "НАЖМИ МЕНЯ";
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if(i < 2)
            {
                button1.Text = "Вы нажа-а-а-а-ли меня!!!!";
                i++;
            }
            else Close();
        }
    }
}

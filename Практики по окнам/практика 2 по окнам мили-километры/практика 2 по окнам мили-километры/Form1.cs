using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика_2_по_окнам_мили_километры
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                label2.Text = "Указанное число миль равно: " + double.Parse(textBox1.Text) * 1.61 + "км";
            else label2.Text = "Вы не указали число милей";

        }
    }
}

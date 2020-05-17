using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace фоновая_6._1_Кнопки
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        int h;
        int w;
        public Form1()
        {
            InitializeComponent();
            x = buttonB.Left;
            y = buttonB.Top;
            h = buttonB.Right - buttonB.Width;
            w = buttonА.Width;
        }

        private void ButtonА_Click(object sender, EventArgs e)
        {
            if(h >= 10)
            {
                buttonB.Left = buttonB.Left - 10;
                h = h - 10;
            }
            else
            {
                buttonB.Left = x;
                buttonB.Top = y;
                h = buttonB.Right - buttonB.Width;
            }
        }

        private void ButtonB_Click(object sender, EventArgs e)
        {
            if (buttonА.Width >= 50)
            {
                buttonА.Width = buttonА.Width - 2;
            }
            else buttonА.Width = w;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Width = Form1.ActiveForm.Width + 20;
            Form1.ActiveForm.Height = Form1.ActiveForm.Height + 20;
            buttonB.Left = buttonB.Left + 20;
            buttonА.Left = buttonА.Left + 20;
            h = buttonB.Right - buttonB.Width;
            x = buttonB.Left;
            y = buttonB.Top;
        }
    }
}

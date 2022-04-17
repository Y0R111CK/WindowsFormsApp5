using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
                TextBox btn = new TextBox();
                btn.Parent = this;
                btn.Location = new Point(10, 100);
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Button btn = new Button();
            btn.Location = new Point(100, 10);
            panel1.Controls.Add(btn);
        }
    }
}

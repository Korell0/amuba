using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amuba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://hu.wikipedia.org/wiki/Am%C5%91ba_(j%C3%A1t%C3%A9k)");
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Rules.Visible = true;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Rules.Visible = false;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Rules.Location = new Point(RelMousPoz().X - Rules.Width, RelMousPoz().Y);
            Rules.BringToFront();
        }
        private Point RelMousPoz()
        {
            return new Point(MousePosition.X - this.Location.X - 8, MousePosition.Y - this.Location.Y - 30);
        }

    }
}


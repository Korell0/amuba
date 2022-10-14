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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void oneplayer_Click(object sender, EventArgs e)
        {
            Player_s(1);
        }

        private void Player_s(int number)
        {
            List<TextBox> jatekosokneve = new List<TextBox>();
            for (int i = 0; i < number; i++)
            {
                Label ujlabel = new Label();
                ujlabel.Text = $"Player {i+1} name";
                ujlabel.Name = $"player{i + 1}";
                ujlabel.Location = new Point(30, 40 + i * (ujlabel.Height + 30));
                this.Controls.Add(ujlabel);

                TextBox ujtextbox = new TextBox();
                ujtextbox.Name = $"player{i + 1}";
                ujtextbox.Location = new Point(ujlabel.Width+30, 40 + i * (ujlabel.Height + 30));
                this.Controls.Add(ujtextbox);

            }
            button1.Visible = true;
            oneplayer.Visible = false;
            twoplayer.Visible = false;

        }

        private void twoplayer_Click(object sender, EventArgs e)
        {
            Player_s(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}

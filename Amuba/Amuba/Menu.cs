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
        static List<TextBox> jatekosnevek = new List<TextBox>();
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
            for (int i = 0; i < number; i++)
            {
                Label ujlabel = new Label();
                ujlabel.Text = $"Player {(number == 1 ? "" : (i + 1).ToString() + " ")}Name: ";
                ujlabel.Name = $"player{i + 1}";
                ujlabel.AutoSize = true;
                this.Controls.Add(ujlabel);

                TextBox ujtextbox = new TextBox();
                ujtextbox.Text = $"Player{i + 1}";
                this.Controls.Add(ujtextbox);

                int xHelyzet = this.Width / 2 - (ujlabel.Width + ujtextbox.Width) / 2 - 30;
                int yHelyzet = (this.Height - (ujlabel.Height * number + (number - 1) * 30)) / 2 + (i * (30 + ujlabel.Height)) - 26;
                ujlabel.Location = new Point(xHelyzet, yHelyzet);
                ujtextbox.Location = new Point(ujlabel.Width + ujlabel.Location.X, ujlabel.Location.Y - 3);

                jatekosnevek.Add(ujtextbox);
            }
            startBtn.Visible = true;
            oneplayer.Visible = false;
            twoplayer.Visible = false;
        }

        private void twoplayer_Click(object sender, EventArgs e)
        {
            Player_s(2);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            List<string> nevek = new List<string>();
            foreach (TextBox item in jatekosnevek)
            {
                nevek.Add(item.Text);
            }
            new Form1(nevek.Count > 1 && new Random().Next(0, 2) > 0 ? new List<string> { nevek[1], nevek[0] } : nevek).Show();
            this.Hide();
        }
    }
}
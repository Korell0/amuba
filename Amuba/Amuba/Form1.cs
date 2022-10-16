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
    public sealed partial class Form1 : Form
    {
        static List<Jatekos> jatekosok = new List<Jatekos>();
        static Jatekos jatekos;
        static Mezo[,] Palya = new Mezo[10,10];
        public Form1(List<string> nevek)
        {
            InitializeComponent();
            GeneratePlayers(nevek);
            GenerateMap();

        }

        private void GeneratePlayers(List<string> nevek)
        {
            if (nevek.Count == 1)
            {
                jatekosok.Add(new Jatekos("Artificial Intelligence", jatekosok.Count == 0 ? "X" : "O"));
            }
            foreach (string nev in nevek)
            {
                jatekosok.Add(new Jatekos(nev, jatekosok.Count == 0 ? "X" : "O")); // így az X kezd!!!!4444négy
            }
            jatekos = jatekosok[0];
            Jelenleg();
        }

        private void Jelenleg()
        {
            JelenlegiPBox.Image = Image.FromFile($"{jatekosok.Find(x => x.Jel != jatekos.Jel).Jel}.png");
            nextLabel.Text = $"Következik:\n{jatekosok.Find(x => x.Jel != jatekos.Jel).Nev}";
        }

        public static string Aktiv()
        {
            jatekos = jatekosok.Find(x => x.Jel != jatekos.Jel);
            return jatekos.Jel;
        }

        private void GenerateMap()
        {
            int gap = 10; //px
            int meret = ((groupBox1.Height -91) / Palya.GetLength(1)) - (gap/ (Palya.GetLength(1) - 1));

            int kezdoX = gap;
            int kezdoY = (groupBox1.Height - (Palya.GetLength(1) * meret + (Palya.GetLength(1) - 1) * gap))/2;

            for (int sor = 0; sor < Palya.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < Palya.GetLength(1); oszlop++)
                {
                    int xHelyzet = kezdoX + oszlop * meret + oszlop * gap;
                    int yHelyzet = kezdoY + sor * meret + sor * gap;
                    Palya[sor, oszlop] = new Mezo(new Point(xHelyzet, yHelyzet), new Size(meret, meret));
                    Palya[sor, oszlop].Kep.Click += Kep_Click;
                    this.Controls.Add(Palya[sor, oszlop].Kep);
                }
            }
        }

        private void Kep_Click(object sender, EventArgs e)
        {
            Jelenleg();
        }

        private Point RelMousPoz()
        {
            return new Point(MousePosition.X - this.Location.X - 8, MousePosition.Y - this.Location.Y - 38);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void infoLabel_MouseEnter(object sender, EventArgs e)
        {
            Rules.Visible = true;
        }

        private void infoLabel_MouseLeave(object sender, EventArgs e)
        {
            Rules.Visible = false;
        }

        private void infoLabel_MouseMove(object sender, MouseEventArgs e)
        {
            Rules.Location = new Point(RelMousPoz().X - 10 - Rules.Width, RelMousPoz().Y);
            Rules.BringToFront();
        }
    }
}


﻿using System;
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
            Winchek();
        }

        private void Winchek()
        {
            for (int sor = 0; sor < Palya.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < Palya.GetLength(1); oszlop++)
                {
                    if (Palya[sor,oszlop].Ertek!="")
                    {
                        if (Vizszintes(sor, oszlop) ||
                            Fuggoleges(sor, oszlop) ||
                            Shrejobbra(sor, oszlop) ||
                            Shrebalra(sor, oszlop))
                        {
                            MessageBox.Show($"A győztes:\n{jatekosok.Find(x => x.Jel == Palya[sor, oszlop].Ertek).Nev}\n Szeretnél újra játszani?", "Győzelem", MessageBoxButtons.YesNo);
                            ClearMap();
                        }
                    }
                }
            }
        }

        private void ClearMap()
        {
            for (int sor = 0; sor < Palya.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < Palya.GetLength(1); oszlop++)
                {
                    Palya[sor, oszlop].Kep.Image = null;
                    Palya[sor, oszlop].Szabad = true;
                    Palya[sor, oszlop].Ertek = "";
                }
            }
        }

        private bool Shrebalra(int sor, int oszlop)
        {
            int iterate = 0;

            for (int row = sor; row < Palya.GetLength(0); row++)
            {
                for (int column = oszlop; column >= 0; column--)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (sor + i == row && oszlop - i == column)
                        {
                            if (Palya[sor, oszlop].Ertek == Palya[row, column].Ertek)
                            {
                                iterate++;
                            }
                            else
                            {
                                return false;
                            }
                            if (iterate > 4)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;

        }

        private bool Shrejobbra(int sor, int oszlop)
        {
            int iterate = 0;

            for (int row = sor; row < Palya.GetLength(0); row++)
            {
                for (int column = oszlop; column < Palya.GetLength(1); column++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (sor + i == row && oszlop + i == column)
                        {
                            if (Palya[sor, oszlop].Ertek == Palya[row, column].Ertek)
                            {
                                iterate++;
                            }
                            else
                            {
                                return false;
                            }
                            if (iterate > 4)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;

        }

        private bool Fuggoleges(int sor, int oszlop)
        {
            int iterate = 0;
            for (int row = sor; row < Palya.GetLength(1); row++)
            {
                if (Palya[sor, oszlop].Ertek == Palya[row, oszlop].Ertek)
                {
                    iterate++;
                }
                else
                {
                    return false;
                }
                if (iterate > 4)
                {
                    return true;
                }
            }
            return false;
        }

        private bool Vizszintes(int sor, int oszlop)
        {
            int iterate = 0;
            for (int column = oszlop; column < Palya.GetLength(1); column++)
            {
                if (Palya[sor,oszlop].Ertek == Palya[sor, column].Ertek)
                {
                    iterate++;
                }
                else
                {
                    return false;
                }
                if (iterate > 4)
                {
                    return true;
                }
            }
            return false;
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Amuba
{
    class Mezo
    {
        public PictureBox Kep;
        public bool Szabad;
        public string Ertek;




        public Mezo(Point hely, Size meret)
        {
            Kep = new PictureBox();
            Kep.Location = hely;
            Kep.Size = meret;
            Kep.BackColor = Color.White;
            Kep.BorderStyle = BorderStyle.FixedSingle;
            Kep.Visible = true;
            Kep.SizeMode = PictureBoxSizeMode.Zoom;
            Szabad = true;
            Ertek = "";

            Kep.Name = Form1.Aktiv();
            Kep.Click += delegate (object sender, EventArgs e) { Kep_Click(sender, e, Szabad ? Form1.Aktiv() : null); };
            Kep.MouseEnter += delegate (object sender, EventArgs e) { Hover(sender, e, Szabad ? Form1.Elonezet() : null); };
            Kep.MouseLeave += Normalize;
        }

        private void Normalize(object sender, EventArgs e)
        {
            Kep.BackColor = Color.White;
            if (Szabad)
            {
                Kep.Image = null;
            }
        }

        private void Hover(object sender, EventArgs e, string name)
        {
            if (Szabad)
            {
                Kep.BackColor = Color.FromArgb(100, 199, 199, 199);
                Kep.Image = Image.FromFile($"{name}_transparent.png");
            }
        }

        private void Kep_Click(object sender, EventArgs e, string name)
        {
            if (Szabad)
            {
                Kep.Image = Image.FromFile($"{name}.png");
                Szabad = false;
                Ertek = name;
                Kep.BackColor = Color.White;
                Kep.BorderStyle = BorderStyle.Fixed3D;
            }
        }
    }
}

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
            Kep.Visible = true;
            Kep.SizeMode = PictureBoxSizeMode.Zoom;
            Szabad = true;
            Ertek = "";

            Kep.Name = Form1.Aktiv();
            Kep.Click += delegate (object sender, EventArgs e) { Kep_Click(sender, e, Szabad ? Form1.Aktiv() : null); };
        }

        private void Kep_Click(object sender, EventArgs e, string name)
        {
            if (Szabad)
            {
                Kep.Image = Image.FromFile($"{name}.png");
                Szabad = false;
                Ertek = name;
            }
        }
    }
}

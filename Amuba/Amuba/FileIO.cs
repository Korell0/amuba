using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;



namespace Amuba
{
    class FileIO
    {
        public static void EredmenyekMentese(List<Jatekos> jatekosok)
        {
            try
            {
                StreamWriter iras = new StreamWriter("Eredmenyek.txt",append:true);
                if (jatekosok[0].Pont==jatekosok[1].Pont)
                {
                    iras.WriteLine($"Döntetlen: {jatekosok[0].Nev} - {jatekosok[0].Pont} : {jatekosok[1].Pont} - {jatekosok[1].Nev}");
                }
                else
                {
                    Jatekos gyoztes = jatekosok.Find(x => x.Pont == jatekosok.Max(y => y.Pont));

                    iras.WriteLine($"Győztes: {gyoztes.Nev} - {gyoztes.Pont} : {jatekosok.Find(x =>x !=gyoztes).Pont} - {jatekosok.Find(x => x != gyoztes).Nev}");
                }
                iras.Close();
                
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}");
                
            }
        
        }



    }
}

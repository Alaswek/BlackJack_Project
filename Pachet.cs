using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help
{
    public class Pachet
    {
        List<Carti> Pachet_De_Carti = new List<Carti>();
        public static string[] Figura = { "Romb", "Pajura", "Frunza", "Trefla"};
        public static string[] Valori = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        public Pachet()
        {

            foreach(var fig in Figura)
            {
                foreach(var val in Valori)
                {
                    Pachet_De_Carti.Add(new Carti(fig, val));
                }
            }
            AmestecaCartile();
        }

        public void AmestecaCartile()
        {
            Random ran = new Random();
            int Contor_Carti = Pachet_De_Carti.Count;
            for (int i = Contor_Carti - 1; i > 0; i--)
            {
                int j = ran.Next(0, i + 1);
                Carti temp = Pachet_De_Carti[i];
                Pachet_De_Carti[i] = Pachet_De_Carti[j];
                Pachet_De_Carti[j] = temp;
            }
        }

        public Carti TrageCarteDinPachet()
        {
            if (Pachet_De_Carti == null)
            {
                Console.WriteLine("Pachetul e gol boss");
                return null;
            }

            Carti carte_Trasa = Pachet_De_Carti[0];
            Pachet_De_Carti.Remove(carte_Trasa);
            return carte_Trasa;
        }

    }
}

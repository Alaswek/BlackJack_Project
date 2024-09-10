using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help
{
    public class Jucator
    {
        private string _nume;
        public List<Carti> Mana_Jucator { get; set; }
        public string Nume
        {
            get { return _nume; } 
            set { _nume = value; }
        }
        public Jucator(string nume) { 
            // constructor
            this.Nume = nume;
            this.Mana_Jucator = new List<Carti>();
        }

        public virtual void Trage_Carte(Carti carte)
        {
            if (carte != null)
            {
                Mana_Jucator.Add(carte);
                Console.WriteLine($"{Nume} a tras {carte.Valoare} de {carte.Figura}");
            }
        }

        public virtual int Calculeaza_Punctaj()
        {
            int total = 0;
            foreach(var carte in Mana_Jucator)
            {
                total += carte.GetValoare();
            }
            return total;
        }

    }
}

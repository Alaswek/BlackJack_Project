using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help
{
    public class Dealer : Jucator
    {
        List<Carti> Mana_Dealer { get; set; }
        public Dealer() : base("Dealer")
        {
            Mana_Dealer = new List<Carti>();
        }

        public override void Trage_Carte(Carti carte)
        {
            Mana_Dealer.Add(carte);
            Console.WriteLine($"{Nume} a tras {carte.Valoare} de {carte.Figura}");
        }

        public override int Calculeaza_Punctaj()
        {
            int total_dealer = 0;
            foreach (var carte in Mana_Dealer)
            {
                total_dealer += carte.GetValoare();
            }
            return total_dealer;
        }
    }
}

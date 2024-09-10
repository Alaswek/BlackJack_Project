using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help
{
    public class Carti
    {
        private string _figura;
        public string Figura
        {
            get { return _figura; }
            set { _figura = value; }
        }

        private string _valoare;
        public string Valoare
        {
            get { return _valoare; }
            set { _valoare = value; }
        }

        public Carti(string figura, string valoare)
        {
            this.Valoare = valoare;
            this.Figura = figura;
        }

        public int GetValoare()
        {
            if (Valoare == "A")
            {
                return 11;
            }
            else if (Valoare == "J" || Valoare == "Q" || Valoare == "K") {
                return 10;
            }
            return int.Parse(Valoare);
        }

    }
}

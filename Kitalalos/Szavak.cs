using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitalalos
{
    internal class Szavak
    {
        string rejtettszo;
        string tipp;
        string valasz;
        string bevitel;
        public Szavak(string rejtettszo, string tipp, string valasz, string bevitel)
        {
            this.rejtettszo = rejtettszo;
            this.tipp = tipp;
            this.valasz = valasz;
            this.bevitel = bevitel;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public struct szavak
        {
            public string rejtettszo;
            public string tipp;
            public string valasz;
            public string bevitel;
        }
        public Szavak() { }
    }
}

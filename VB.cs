using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Focivb
{
    internal class VB
    {
        public string Varos;
        public string Nev1;
        public string Nev2;
        public int Ferohely;

        public VB (string s)
        {
            var dbok = s.Split(";");
            this.Varos = dbok[0];
            this.Nev1 = dbok[1];
            this.Nev2 = dbok[2];
            this.Ferohely = int.Parse(dbok[3]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class CsacskaNyúl : Versenyfolyamat
    {
        public bool Ordit = false;
        public float Sebesseg;
        public readonly int PersonalID = 3;
        public int MegtettKorok;

        public void Ordit()
        {
            if (Ordit = true)
                Sebesseg = Sebesseg * 1.5;
        }

        internal TréMedve TréMedve
        {
            get
            {
            }

            set
            {
            }
        }
    }
}

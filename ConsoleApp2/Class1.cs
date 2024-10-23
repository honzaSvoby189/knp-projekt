using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kámen_nužky_papír
{
    internal class Hra
    {
        public int SkoreHrac { get; private set; }
        public int SkoreNepritele { get; private set; }

        public Hra()
        {
            SkoreHrac = 0;
            SkoreNepritele = 0;
        }

        public void ZvysitSkoreHrace()
        {
            SkoreHrac++;
        }

        public void ZvysitSkoreNepritele()
        {
            SkoreNepritele++;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Stock
{
    class Gestion_entre
    {
        private int fornicode;

        public int ForniCode
        {
            get { return fornicode; }
            set { fornicode = value; }
        }
        private int codeartice;

        public int ArticleCode
        {
            get { return codeartice; }
            set { codeartice = value; }
        }
        private DateTime entredate;

        public DateTime EntreDate
        {
            get { return entredate; }
            set { entredate = value; }
        }
        private int quantitie;

        public int Quantitie
        {
            get { return quantitie; }
            set { quantitie = value; }
        }

    }
}

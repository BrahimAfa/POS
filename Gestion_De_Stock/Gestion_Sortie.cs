using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Stock
{
    class Gestion_Sortie
    {
        private int clientcode;

        public int ClientCode
        {
            get { return clientcode; }
            set { clientcode = value; }
        }
        private int codeartice;

        public int ArticleCode
        {
            get { return codeartice; }
            set { codeartice = value; }
        }
        private  DateTime sortidate;

        public  DateTime SortiDate
        {
            get { return sortidate; }
            set { sortidate = value; }
        }
        private int quantitie;

        public int Quantitie
        {
            get { return quantitie; }
            set { quantitie = value; }
        }



    }
}

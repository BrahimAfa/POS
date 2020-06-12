using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Stock
{
    class Fornisseur
    {
        public static List<Fornisseur> ForniList = new List<Fornisseur>();
        private int fornicode;

        public int ForniCode
        {
            get { return fornicode; }
            set { fornicode = value; }
        }
        private string rsxsocial;

        public string RsxSocial
        {
            get { return rsxsocial; }
            set { rsxsocial = value; }
        }
        private string adress;

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        private string tele;

        public string Tele
        {
            get { return tele; }
            set { tele = value; }
        }

        public Fornisseur() { }
        public Fornisseur(int Fornicode, string Rsxsocial, string adress,string tele)
        {
            this.ForniCode = Fornicode;
            this.RsxSocial = Rsxsocial;
            this.Adress = adress;
            this.Tele = tele;
        }

    }
}

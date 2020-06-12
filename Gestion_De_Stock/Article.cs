using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Stock
{
     class Article
     {
        private int Articlcode;
        private string disignation;
        private double prixachat;
        private string famillarticle;
        private int qtestock;

      
        public int Articl_Code
        {
            get { return Articlcode; }
            set { Articlcode = value; }
        }
        public string Famill_Article
        {
            get { return famillarticle; }
            set { famillarticle = value; }
        }
        public string Disignation
        {
            get { return disignation; }
            set { disignation = value; }
        }

        public double PrixAchat
        {
            get { return prixachat ; }
            set { prixachat = value; }
        }

        //public double PrixVent
        //{
        //    get { return prixvent; }
        //    set { prixvent = value; }
        //}

        public int QteStock
        {
            get { return qtestock; }
            set { qtestock = value; }
        }

        public Article() { }

        public Article(int articlcode,double prixachat , string disignation,int Qtestock,string famillarticl)
        {
            this.Famill_Article = famillarticl;
            this.Articlcode = articlcode;
            this.Disignation = disignation;
            this.PrixAchat = prixachat;
            this.QteStock = Qtestock;
        }




















    }
}

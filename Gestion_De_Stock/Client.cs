using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Stock
{
    class Client
    {
        public static List<Client> ClientList = new List<Client>();
        public  List<Article> ArticleList = new List<Article>();
        private int clientcode;
        private string nom;
        private string prenom;
        private string adress;
        private string tele;
        private int prixtotal;
       
        public int PrixTotal {
            get => prixtotal;
            set { prixtotal = value; }
        }
        public int ClientCode
        {
            get { return clientcode; }
            set { clientcode = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public string Tele
        {
            get { return tele; }
            set { tele = value; }
        }

        public Client() { }
        public Client(int clientcode, string nom, string prenom, string adress, string tele,int PrixTotal)
        {
            this.ClientCode = clientcode;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Adress = adress;
            this.Tele = tele;
            this.PrixTotal = PrixTotal;
        }
        public Client (int clientcode,string nom ,string prenom,string adress,string tele)
        {
            this.ClientCode = clientcode;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Adress = adress;
            this.Tele = tele;
        }
        public override string ToString()
        {
            return ClientCode+"|"+Nom+"|"+Prenom+"|"+Adress+"|"+Tele+"|";
        }
    }
}

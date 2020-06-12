using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Stock
{
    class  FamileArticle
    {

      public static List<FamileArticle> Famile_Articl_List = new List<FamileArticle>{ new FamileArticle(1, "AUDI"), new FamileArticle(2, "SKODA"), new FamileArticle(3, "VOLKSWAGEN") };
      public List<Article> ArticleList = new List<Article>();

        private int familecode;
        private string familenom;

        public int FamileCode
        {
            get { return familecode; }
            set { familecode = value; }
        }

        public string FamileNom
        {
            get { return familenom; }
            set { familenom = value; }
        }

        public FamileArticle() { }

        public FamileArticle(int familcode,string familnom)
        {
            this.FamileCode = familcode;
            this.FamileNom = familnom;
        }


    }
}

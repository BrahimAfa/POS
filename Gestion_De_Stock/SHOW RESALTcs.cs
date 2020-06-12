using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Gestion_De_Stock
{
    public partial class SHOW_RESALTcs : Form
    {
        public SHOW_RESALTcs()
        {
            InitializeComponent();
        }
        
        private void label_Click(object sender, EventArgs e)
        {
            
        }

        private void SHOW_RESALTcs_Load(object sender, EventArgs e)
        {
            foreach (var item in Client.ClientList)
            {
                dataGridViewClient.Rows.Add(item.ClientCode,
                    item.Nom,
                    item.Prenom,
                    item.Adress,
                    item.Tele);
            }
            for (int i = 0; i < Client.ClientList.Count; i++)
            {
                
                foreach (var item in Client.ClientList[i].ArticleList)
                {
                    dataGridView2.Rows.Add(Client.ClientList[i].ClientCode, 
                        Client.ClientList[i].Nom, 
                        Client.ClientList[i].Prenom,
                        item.Articl_Code,
                        item.Disignation,
                        item.Famill_Article,
                        item.PrixAchat, 
                        item.QteStock, Client.ClientList[i].PrixTotal
                        );
                }
            }
            for (int i = 0; i < FamileArticle.Famile_Articl_List.Count; i++)
            {
                foreach (var item in FamileArticle.Famile_Articl_List[i].ArticleList)
                {
                    dataGridViewArticl.Rows.Add(item.Articl_Code,item.Disignation,item.PrixAchat,item.QteStock, FamileArticle.Famile_Articl_List[i].FamileNom);
                }
            }
            
        }

        private void dataGridViewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewArticl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

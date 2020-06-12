using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Stock
{
    public partial class Article_Client : Form
    {
        public Article_Client()
        {
            InitializeComponent();
        }

        private void Article_Form_Load(object sender, EventArgs e)
        {
            foreach (var item in FamileArticle.Famile_Articl_List)
            {
                comboBoxAFamille.Items.Add(item.FamileNom);
            }
            //foreach (var item in Client.ClientList)
            //{
            //    comboBoxCcode.Items.Add(item.ClientCode);
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in FamileArticle.Famile_Articl_List)
            {
                if (item.FamileNom == comboBoxAFamille.Text)
                {
                    textBoxFamilleCode.Text = item.FamileCode.ToString();
                }

            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (textBoxFamilleCode.Text == "" && textBoxAcode.Text == "" && textBoxPrix.Text == "" && textBoxDisignation.Text == "" && textBoxQteStock.Text == "")
            {
                MessageBox.Show("Pleas Fill all The Boxes!!!!");
            }
            if (textBoxFamilleCode.Text == "")
            {
                MessageBox.Show("Pleas choice Famille Article");
            }

            for (int i = 0; i < Client.ClientList.Count; i++)
            {
                //if (Client.ClientList[i].ClientCode == Convert.ToInt32(comboBoxCcode.Text))
                //{
                    
                //    Client.ClientList[i].ArticleList.Add(new Article(int.Parse(textBoxAcode.Text), double.Parse(textBoxPrix.Text),textBoxDisignation.Text,int.Parse(textBoxQteStock.Text),comboBoxAFamille.Text));
                //}
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

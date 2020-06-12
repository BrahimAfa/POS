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
    public partial class Client_Form : Form
    {
        public Client_Form()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int P = 0;
        
       
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //dik l combobox dyal lcode client mazal madartch l code dyalha 
            //pay attention 
            Client CL = new Client(
    int.Parse(textBoxCode.Text),
    textBoxNom.Text,
    textBoxPrenom.Text,
    textBoxAdress.Text,
    textBoxTele.Text
    //,
    //int.Parse(labelTotal.Text)
    );
            if (checkBox1.Checked)
            {
                
                Client.ClientList.Add(CL);
                

            }
            else
            {
                Client.ClientList.Add(CL);
                Client.ClientList[P].ArticleList.Add(new Article(int.Parse(textBoxACode.Text), double.Parse(textBoxPrix.Text), comboBoxDisignation.Text, int.Parse(textBoxQte.Text), comboBoxAfamille.Text));
                for (int i = 0; i < FamileArticle.Famile_Articl_List.Count; i++)
                {
                    foreach (var item in FamileArticle.Famile_Articl_List[i].ArticleList)
                    {
                        if (comboBoxDisignation.Text == item.Disignation)
                        {
                            item.QteStock = item.QteStock - int.Parse(textBoxQte.Text);
                        }
                    }
                }
            }


            


            //StreamWriter ClientFile = new StreamWriter(@"C:\Users\ToShi\Desktop\proxieees\Client.txt");
            //foreach (var item in Client.ClientList)
            //{
            //    ClientFile.WriteLine(item.ToString());
            //}
           // ClientFile.Close();
         
                File.AppendAllText(@"C:\Users\ToShi\Desktop\Client.txt",CL.ToString() + Environment.NewLine);
            
            

            textBoxNom.Clear();
                textBoxPrenom.Clear();
                textBoxAdress.Clear();
                textBoxTele.Clear();

            P++;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Client_Form_Load(object sender, EventArgs e)
        {
            foreach (var item in FamileArticle.Famile_Articl_List)
            {
                comboBoxAfamille.Items.Add(item.FamileNom);
            }
        }
        int ArticlePosistion;
        private void comboBoxAfamille_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < FamileArticle.Famile_Articl_List.Count; i++)
            {
                if (comboBoxAfamille.Text== FamileArticle.Famile_Articl_List[i].FamileNom)
                {
                    ArticlePosistion = i;
                    textBoxFamillC.Text = FamileArticle.Famile_Articl_List[i].FamileCode.ToString();
                    comboBoxDisignation.Items.Clear();
                    comboBoxDisignation.Text = "";
                    foreach (var item in FamileArticle.Famile_Articl_List[i].ArticleList)
                    {
                        comboBoxDisignation.Items.Add(item.Disignation);
                    }
                }
            }
        }

        private void comboBoxDisignation_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in FamileArticle.Famile_Articl_List[ArticlePosistion].ArticleList)
            {
                if (comboBoxDisignation.Text == item.Disignation)
                {
                    textBoxACode.Text = item.Articl_Code.ToString();
                    textBoxQteLeft.Text = item.QteStock.ToString();
                    textBoxPrix.Text = Convert.ToString(item.PrixAchat+((item.PrixAchat*20)/100));
                }
            }
        }

        private void textBoxQte_TextChanged(object sender, EventArgs e)
        {
            if (textBoxQte.Text != "")
            {
                if ( int.Parse(textBoxQte.Text) <= int.Parse(textBoxQteLeft.Text))
                {
                    labelTotal.Text = Convert.ToString(int.Parse(textBoxPrix.Text) * int.Parse(textBoxQte.Text));
                }
                else
                {
                    labelTotal.Text = "Stock Insufissant";
                }
                
            }
            
        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }
        int CP = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            CP = 0;
            textBoxCode.Text = Client.ClientList[CP].ClientCode.ToString();
            textBoxPrenom.Text = Client.ClientList[CP].Prenom;
            textBoxAdress.Text = Client.ClientList[CP].Adress;
            textBoxNom.Text = Client.ClientList[CP].Nom;
            textBoxTele.Text = Client.ClientList[CP].Tele;
            button2.Enabled = false;
            if (button3.Enabled == false)
            {
                button3.Enabled = true;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CP = Client.ClientList.Count - 1;
            
            textBoxCode.Text = Client.ClientList[CP].ClientCode.ToString();
            textBoxPrenom.Text = Client.ClientList[CP].Prenom;
            textBoxAdress.Text = Client.ClientList[CP].Adress;
            textBoxNom.Text = Client.ClientList[CP].Nom;
            textBoxTele.Text = Client.ClientList[CP].Tele;
            button3.Enabled = false;
            if (!button2.Enabled)
            {
                button2.Enabled = true;
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (CP==0)
            {
                textBoxCode.Text = Client.ClientList[0].ClientCode.ToString();
                textBoxPrenom.Text = Client.ClientList[0].Prenom;
                textBoxAdress.Text = Client.ClientList[0].Adress;
                textBoxNom.Text = Client.ClientList[0].Nom;
                textBoxTele.Text = Client.ClientList[0].Tele;
                if (button2.Enabled)
                { 
                    button2.Enabled = false;
                }
                

            }
            else
            {
                CP--;
                textBoxCode.Text = Client.ClientList[CP].ClientCode.ToString();
                textBoxPrenom.Text = Client.ClientList[CP].Prenom;
                textBoxAdress.Text = Client.ClientList[CP].Adress;
                textBoxNom.Text = Client.ClientList[CP].Nom;
                textBoxTele.Text = Client.ClientList[CP].Tele;
                button3.Enabled = true;
            }
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int l = Client.ClientList.Count - 1;
            if (CP == l)
            {
                textBoxCode.Text = Client.ClientList[l].ClientCode.ToString();
                textBoxPrenom.Text = Client.ClientList[l].Prenom;
                textBoxAdress.Text = Client.ClientList[l].Adress;
                textBoxNom.Text = Client.ClientList[l].Nom;
                textBoxTele.Text = Client.ClientList[l].Tele;
                button3.Enabled = false;

            }
            else
            {
               
                CP++;

                textBoxCode.Text = Client.ClientList[CP].ClientCode.ToString();
                textBoxPrenom.Text = Client.ClientList[CP].Prenom;
                textBoxAdress.Text = Client.ClientList[CP].Adress;
                textBoxNom.Text = Client.ClientList[CP].Nom;
                textBoxTele.Text = Client.ClientList[CP].Tele;
                if (button2.Enabled == false)
                {
                    button2.Enabled = true;
                }
                
            }
        }

        private void textBoxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //remember for key pressing
            //Keys.Add
        }



        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Add_Article : Form
    {
        public Add_Article()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Height+=2 ;
            
            if (panel2.Height == 60 )
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel2.Height-=2;
            if (panel2.Height == 0)
            {
                timer2.Stop();
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Add_Article_Load(object sender, EventArgs e)
        {
            foreach (var item in FamileArticle.Famile_Articl_List)
            {
                comboBoxFamillA.Items.Add(item.FamileNom);
            }
        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBoxFamillC.Clear();
                textBoxFamillC.Enabled = false;
                comboBoxFamillA.Enabled = false;
                timer1.Start();
                //panel1.Height=88;


            }
            else
            {
                textBoxFamillC.Enabled = true;
                comboBoxFamillA.Enabled = true;
                timer2.Start();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            /* Button Start */
            if(checkBox1.Checked==true )
            {
                if (textBoxArticleC.Text != "" &&
                   textBoxPrix.Text != "" && 
                   textBoxDisignation.Text != "" && 
                   textBoxQteStock.Text != "" )
             

                {
                    if (textBoxNfamillA.Text != "" && textBoxNewFamillC.Text != "")
                    {
                        FamileArticle.Famile_Articl_List.Add(
                            new FamileArticle(
                                int.Parse(textBoxNewFamillC.Text),
                                textBoxNfamillA.Text));

                        for (int i = 0; i < FamileArticle.Famile_Articl_List.Count; i++)
                        {
                            if (textBoxNewFamillC.Text == FamileArticle.Famile_Articl_List[i].FamileCode.ToString())
                            {
                                FamileArticle.Famile_Articl_List[i].ArticleList.Add(
                                    new Article(
                                    int.Parse(textBoxArticleC.Text),
                                    double.Parse(textBoxPrix.Text),
                                    textBoxDisignation.Text,
                                    int.Parse(textBoxQteStock.Text),
                                    textBoxNewFamillC.Text));
                            }

                        }

                        MessageBox.Show("the article Was Added succesfully withe the (new family) ");
                    }
                    else
                    {
                        MessageBox.Show("Pleas enter The new famill information (newfamilly)");
                    }
                }
                else
                {
                    MessageBox.Show("you are required to fill all the boxes (new familly)");
                }


                
            }
            else
            {
                if (textBoxArticleC.Text!=""&& 
                    textBoxPrix.Text != "" && 
                    textBoxDisignation.Text != "" && 
                    textBoxQteStock.Text != "" && 
                    comboBoxFamillA.Text != "")
                    //COndition
                {
                    for (int i = 0; i < FamileArticle.Famile_Articl_List.Count; i++)
                    {
                        if (textBoxFamillC.Text == FamileArticle.Famile_Articl_List[i].FamileCode.ToString())
                        {
                            FamileArticle.Famile_Articl_List[i].ArticleList.Add(
                                 new Article(
                                 int.Parse(textBoxArticleC.Text),
                                 double.Parse(textBoxPrix.Text),
                                 textBoxDisignation.Text,
                                 int.Parse(textBoxQteStock.Text),
                                 comboBoxFamillA.Text));
                        }
                    }
                    MessageBox.Show("the article Was Added succesfully (No new Familly) ");
                }
                else
                {
                    MessageBox.Show("Pleas fill all the boxes  are required \n(No new familly) ");
                }
                   

            }

            /* Button End */
        }

        private void comboBoxFamillA_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in FamileArticle.Famile_Articl_List)
            {
                if (comboBoxFamillA.Text==item.FamileNom)
                {
                    textBoxFamillC.Text = item.FamileCode.ToString();
                }
                  
            }
        }


    }
}

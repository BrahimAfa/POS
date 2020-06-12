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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
     
       
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Client_Form CF = new Client_Form();
            CF.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            SHOW_RESALTcs sh = new SHOW_RESALTcs();
            sh.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Add_Article AA = new Add_Article();
            AA.Show();
        }
    }
}

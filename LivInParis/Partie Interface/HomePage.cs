using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivInParis
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientPage clientPage = new ClientPage();
            this.Hide(); 
            clientPage.ShowDialog();
            this.Hide();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CuisinierPage cuis = new CuisinierPage();
            this.Hide();
            cuis.ShowDialog();
            this.Hide();
           
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}

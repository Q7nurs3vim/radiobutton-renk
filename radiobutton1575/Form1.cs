using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radiobutton1575
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

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
            {
               this.BackColor = Color.Blue;  
            }
            else if(rbRed.Checked) 
            {
              this.BackColor= Color.Red;
            }
            else if (rbWhite.Checked)
            {
               this.BackColor = Color.White;
            }
            else if (rbBlack.Checked)
            {
                this.BackColor= Color.Black;    
            }
        }  
    }
}

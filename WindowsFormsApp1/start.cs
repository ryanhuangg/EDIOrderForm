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

namespace EDIForm
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newOrder_Click(object sender, EventArgs e)
        {
            String poNum = this.Controls["PONum"].Text;
            if (poNum != "")
            {
                if (Directory.Exists("C:\\Ultraseal"))
                {
                    Input order = new Input(poNum);
                    order.Show();
                }
                else
                {
                    Directory.CreateDirectory("C:\\Ultraseal");
                    Input order = new Input(poNum);
                    order.Show();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid PO number.");
            }
       

            
            
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

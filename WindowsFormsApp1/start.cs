using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            Input order = new Input(poNum);
            
            order.Show();
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

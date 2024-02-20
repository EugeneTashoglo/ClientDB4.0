using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDB4._0
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();
           
        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientEdit editClientForm = new ClientEdit();
            editClientForm.Show();
    }


        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
    
}

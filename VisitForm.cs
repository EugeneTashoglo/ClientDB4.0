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
    public partial class VisitForm : Form
    {
        private Client client;
        public VisitForm (Client client)
        {
            InitializeComponent();
            this.client = client;
            using (ModelDB db=new ModelDB())
            {
                List<ClientService> list = db.ClientService.Where(p => p.LastName == client.LastName).ToList();
                foreach(ClientService cs in list)
                {
                    ClientControl cc = new ClientControl();
                    cc.NameService = cs.ServiceID;
                    cc.CountFile = "";
                    cc.StartTime = cs.StartTime.ToString();
                    flowLayoutPanel1.Controls.Add(cc);
                }
            }
        }

    private void flowLayoutPanel1_Paint ( object sender, PaintEventArgs e )
        {
            
        }


        private void button1_Click ( object sender, EventArgs e )
        {

        }
    }
}

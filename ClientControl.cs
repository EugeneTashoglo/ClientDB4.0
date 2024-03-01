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
    public partial class ClientControl : UserControl
    {

        public ClientControl ()
        {
            InitializeComponent();
        }
        public string NameService
        {
            get { return labelNameService.Text; }
            set { labelNameService.Text = value; }
        }
        public string StartTime
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string CountFile
        {
            get { return Countfile.Text; }
            set { Countfile.Text = value; }
        }

    }
}

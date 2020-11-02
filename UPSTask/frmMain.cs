using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPSTask.UserControls;


namespace UPSTask
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if(!pnlCU.Contains(ucDataView.Instance))
            {
                pnlCU.Controls.Add(ucDataView.Instance);
                ucDataView.Instance.Dock = DockStyle.Fill;                             
            }
            ucDataView.Instance.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

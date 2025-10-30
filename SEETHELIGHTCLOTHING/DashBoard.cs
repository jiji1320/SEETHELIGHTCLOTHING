using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEETHELIGHTCLOTHING
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblMyProfile_Click(object sender, EventArgs e)
        {
            var MyProFile = new MyProfile();
            this.Hide();
            MyProFile.FormClosed += (s, args) => this.Close();
            MyProFile.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}

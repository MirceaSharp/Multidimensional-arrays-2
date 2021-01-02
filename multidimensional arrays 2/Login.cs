using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multidimensional_arrays_2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "Mircea" && txtPass.Text == "Greece2020")
            {
                Array array = new Array();
                array.Show();
            }
            else
            {
                MessageBox.Show("You need to fill in a valid username");
                txtUser.Clear();
                txtPass.Clear();
            }
        }
    }
}

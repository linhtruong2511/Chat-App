using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_App
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if(txbUserName.Text == "admin" & txbPassword.Text == "12345")
            {
                DialogResult= DialogResult.OK;
                try
                {
                    fMain fmain = new fMain();
                    fmain.ShowDialog();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "system message");
                }
                
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            try
            {
                fRegister fregister = new fRegister();
                fregister.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "system message");
            }
            Close();
        }
    }
    
}

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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        //private void fMain_Shown(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        fLogin fLog = new fLogin();
        //        fLog.ShowDialog();
        //        if (fLog.DialogResult == DialogResult.Cancel) Close();
        //        else { MessageBox.Show("Login successfully"); }
        //    }
        //    catch(Exception ex) {
        //        MessageBox.Show(ex.Message, "system message");
        //    }
        //}

        private void fMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}

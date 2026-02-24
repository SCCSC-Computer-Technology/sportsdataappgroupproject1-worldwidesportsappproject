using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldWideSports
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoginCreate_Click(object sender, EventArgs e)
        {
            //this takes the user to the login form where they can either log in or create an account
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }





        public void ShowGroupBoxes()  // add this method
        {
            gbxNfl.Visible = true;
            gbxPga.Visible = true;
        }
    }
}

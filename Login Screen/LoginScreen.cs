using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Screen
{
    public partial class LoginScreen : UserControl
    {

        public LoginScreen()
        {
            InitializeComponent();

        }

        private void goButton_Click(object sender, EventArgs e)
        {


            if (passBox.Text == "1234")
            {   
                Form f = FindForm();
                f.Controls.Remove(this);
            }
            else
            {
                failLabel.Visible = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Screen
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            LoginScreen ls = new LoginScreen();
            this.Controls.Add(ls);
            EnterScreen es = new EnterScreen();
            this.Controls.Add(es);
        }
    }
}

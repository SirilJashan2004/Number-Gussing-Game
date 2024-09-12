using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGussingGame
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Sign_Up signup=new Sign_Up();
            signup.Show(); 
            this.Hide();
        }
    }
}

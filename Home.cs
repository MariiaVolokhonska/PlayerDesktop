using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerDesktop
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regestration registration = new Regestration();
            this.Hide();
            registration.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Hide();
            authorization.Show();
        }
    }
}

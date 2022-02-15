using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class AdminMode : Form
    {
        User auth;
        public AdminMode(User auth)
        {
            InitializeComponent();
            this.auth = auth;
        }

        private void AdminMode_Load(object sender, EventArgs e)
        {

        }

        private void httpsgithubcomElhAyoubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://github.com/Elh-Ayoub");
            MessageBox.Show("URL copied to Clipboard!!");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.auth = null;
            var f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f_user = new UserMode(auth);
            f_user.Show();
            this.Hide();
        }

        private void UserListBtn(object sender, EventArgs e)
        {
            //
        }
    }
}

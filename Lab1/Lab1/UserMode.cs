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
    public partial class UserMode : Form
    {
        User auth;
        public UserMode(User auth)
        {
            InitializeComponent();
            this.auth = auth;
        }

        private void UserMode_Load(object sender, EventArgs e)
        {

        }

        private void httpsgithubcomElhAyoubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://github.com/Elh-Ayoub");
            MessageBox.Show("URL copied to Clipboard!!");
        }
    }
}

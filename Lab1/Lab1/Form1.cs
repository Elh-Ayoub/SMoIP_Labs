using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public List<User> users = new List<User>();
        int try_counter = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("users.json") && (File.ReadAllText("users.json") != "" && File.ReadAllText("users.json") != "[]"))
            {
                string json = File.ReadAllText("users.json");
                users = JsonSerializer.Deserialize<List<User>>(json);
            }
            else
            {
                FileStream fs = File.Create("users.json");
                User admin = new User();
                admin.username = "ADMIN";
                admin.password = "ADMIN";
                users.Add(admin);
                fs.Close();

                string jsonString = JsonSerializer.Serialize(users);
                File.WriteAllText("users.json", jsonString);
            }
        }

        private void httpsgithubcomElhAyoubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://github.com/Elh-Ayoub");
            MessageBox.Show("URL copied to Clipboard!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            bool not_found = true;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All fields are required!");
            }
            else
            {
                foreach (var user in users)
                {
                    if (user.username == username)
                    {
                        not_found = false;
                        if (try_counter == 0)
                        {
                            MessageBox.Show(try_counter + " attempts left! You cannot log in.");
                        }
                        else if (user.password == password)
                        {
                            MessageBox.Show("Logged in successfully!");
                            //if (auth.username == "ADMIN")
                            //{
                            ////    var f_admin = new AdminMode(user);
                           //     f_admin.Show();
                           //     this.Hide();
                           // }
                           // else
                           // {
                           //     var f_user = new UserMode(user);
                            //    f_user.Show();
                           //     this.Hide();
                           // }
                        }
                        else
                        {
                            try_counter--;
                            MessageBox.Show("Password incorrect! " + try_counter + " attempts left.");

                            break;
                        }
                    }
                }
                if (not_found)
                {
                    MessageBox.Show("Username not found!");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

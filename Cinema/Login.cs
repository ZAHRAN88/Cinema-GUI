using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using Cinema;

namespace Cinema
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            loginBtn.Click += login_btn;
            gotoSignUp.Click += gotoSignUpBtn;
            password.PasswordChar = '*';
        }
        private void gotoSignUpBtn(object sender, EventArgs e)
        {
            signUp h = new signUp();
            h.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_btn(object sender, EventArgs e)
        {
            filmsList admin = new filmsList();
            if (userName.Text == "admin" && password.Text == "admin")
            {
                this.Hide();
                admin.Show();

            }
            else
            {





                try
                {
                    string[] lines = File.ReadAllLines("users.txt");

                    // Check each line for username and password match
                    for (int i = 0; i < lines.Length; i += 3) // Increment by 3 to skip over the "-------------------" separator "ChatGpt idea"
                    {
                        string storedUsername = lines[i].Substring("Username: ".Length).Trim();
                        string storedPassword = lines[i + 1].Substring("Password: ".Length).Trim();

                        // Check if the entered username and password match the stored ones
                        if (userName.Text == storedUsername && password.Text == storedPassword)
                        {
                            // Authentication successful
                            
                            this.Hide();
                            filmsList h = new filmsList();
                            h.Show();


                           
                            return;
                        }
                    }

                    // If no match found, display error message
                    Erorr.Visible = true;
                   Erorr.Text="User Not Found Please Register first";
                }
                catch (Exception ex)
                {
                    Erorr.Text = $"An error occurred while reading user information:  + {ex.Message}";
                }
            }

        }

    }
}

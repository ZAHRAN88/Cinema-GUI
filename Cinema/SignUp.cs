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
using System.Text.RegularExpressions;
using System.IO;

namespace Cinema
{
    public partial class signUp : Form
    {
        private const string regex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s]).{8,}$";
        public signUp()
        {
            InitializeComponent();
            signUpBtn.Click += signUp_btn;
            gotoLogin.Click += gotoLoginBtn;
           password.PasswordChar = '*';
            textBox1.PasswordChar = '*';
        }
        private void gotoLoginBtn(object sender, EventArgs e)
        {
            Login h = new Login();
            h.Show();
            this.Hide();

        }


        private void signUp_btn(object sender, EventArgs e)
        {

            // Check if password and confirm password match
            if (password.Text != textBox1.Text)
            {
                Erorr.Visible = true;
                Erorr.Text = "Passwords Don't Match!";
                return;
            }

            // Validate password using regex
            if (!Regex.IsMatch(password.Text, regex))
            {
                Erorr.Visible = true;
                //breakline in the error message
                Erorr.Text = "Password must contain at least 8 characters, including uppercase, lowercase, numbers and special characters.";
                return;
            }
            if (!IsUsernameAvailable(userName.Text))
            {
                Erorr.Visible = true;
                Erorr.Text = "User Name already taken ";
                return;
            }


            // Save user information to a text file
            try
            {
                using (StreamWriter writer = new StreamWriter("users.txt", true)) // Append to existing file or create new if not exist
                {
                    writer.WriteLine($"Username: {userName.Text}");
                    writer.WriteLine("Password: " + password.Text);
                    writer.WriteLine("-------------------"); // Add an empty line for separation between users
                }

                

                filmsList h = new filmsList();
                this.Close();
                h.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving user information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
        private bool IsUsernameAvailable(string username)
        {
            // Read all existing usernames from the text file
            string[] existingUsernames = File.ReadAllLines("users.txt");

            // Check if the given username already exists

            foreach (string line in existingUsernames)
            {
                if (line.StartsWith("Username: "))
                {
                    string existingUsername = line.Substring("Username: ".Length);
                    if (existingUsername.Equals(username))
                    {
                        return false; // Username already exists
                    }
                }
            }

            return true; // Username is available
        }
    }
}

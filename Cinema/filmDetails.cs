using System;
using System.IO;
using System.Windows.Forms;

namespace Cinema
{
    public partial class filmDetails : Form
    {
        public filmDetails()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            book.Click += book_btn;
        }

        private void film_Load(object sender, EventArgs e)
        {
            label1.Text = filmsList.selectedFilmName;
            pic.Image = filmsList.selectedImg.Image;

            // Load film description from file
            string filmName = filmsList.selectedFilmName;
            string filePath = "Films.txt";

            if (File.Exists(filePath))
            {
                string description = GetFilmDescription(filmName, filePath);
                textBox1.Text = description;
            }
            else
            {
                MessageBox.Show("File 'Films.txt' not found!");
            }
        }

        private string GetFilmDescription(string filmName, string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            string description = "";
            bool found = false;

            foreach (string line in lines)
            {
                if (line.StartsWith("name:"))
                {
                    string currentFilmName = line.Substring(6).Trim();
                    if (currentFilmName == filmName)
                    {
                        found = true;
                    }
                }
                else if (line.StartsWith("des:") && found)
                {
                    description = line.Substring(4).Trim();
                    break;
                }
            }

            return description;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            filmsList f = new filmsList();
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void book_btn(object sender, EventArgs e)
        {
            Booking_Form b = new Booking_Form();
            b.Show();
            this.Hide();
        }
    }
}

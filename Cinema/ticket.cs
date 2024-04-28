using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cinema
{
    public partial class ticket : Form
    {
        string ticketID; 

        public ticket()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        string x = filmsList.selectedFilmName;
        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("reservations.txt", true)) // Append to existing file or create new if not exist
            {
                ticketID = Guid.NewGuid().ToString().Substring(0, 5);

                writer.WriteLine($"Ticket ID: {ticketID}");
                writer.WriteLine($"Film: {label5.Text}");
                writer.WriteLine("Date And Time: " + label1.Text);
                writer.WriteLine("Booked Chairs: " + label4.Text);
                writer.WriteLine("Total Price: " + label2.Text);
                writer.WriteLine("Screen: " + label3.Text);
                writer.WriteLine("-------------------"); // Add an empty line for separation between reservations
            }

            label5.Text = filmsList.selectedFilmName;
            label1.Text = $"{Booking_Form.date} {Booking_Form.time}";
            label4.Text = $"{string.Join(", ", Booking_Form.bookedChairs)}";
            label2.Text = (Booking_Form.bookedChairs.Count*200).ToString();
            label3.Text = "C23 IMAX Cinema";
            label7.Text =  ticketID;

           
        }
    }
}

using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


namespace Assignment2Programming3
{
    public partial class ManageSubscription : Form
    {
        public ManageSubscription()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string emailAddress = textBox1.Text;

           
            if (IsValidEmail(emailAddress))
            {
               
                SendNotificationEmail(emailAddress);
                MessageBox.Show("Subscription notification sent successfully.");
            }
            else
            {
                MessageBox.Show("Please enter a valid email address.");
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void SendNotificationEmail(string emailAddress)
        {
            try
            {
                
                string senderEmail = "your_email@example.com"; 
                string senderPassword = "your_password"; 

                SmtpClient client = new SmtpClient("smtp.example.com"); 
                client.Port = 587; 
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(senderEmail, senderPassword);

                
                MailMessage message = new MailMessage(senderEmail, emailAddress);
                message.Subject = "Subscription Notification";
                message.Body = "You are subscribed to our service.";

                
                client.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while sending the email: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

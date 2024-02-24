using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2Programming3
{
    public partial class Home : Form
    {
        private LinkedList<int> linkedList;

        public Home()
        {
            InitializeComponent();
            linkedList = new LinkedList<int>();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                linkedList.AddLast(rand.Next(200));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageSubscription manageSubscriptionForm = new ManageSubscription();
            manageSubscriptionForm.Show();
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            string listContent = "Linked List Content:\n";
            foreach (int item in linkedList)
            {
                listContent += item.ToString() + "\n";
            }
            MessageBox.Show(listContent);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


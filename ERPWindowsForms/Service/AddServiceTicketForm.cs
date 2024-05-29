using ERPWindowsForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ERPWindowsForms.Service
{
    public partial class AddServiceTicketForm : Form
    {
        private static ServiceTickets serviceTickets = new ServiceTickets();
        private string selectedLanguage;



        public AddServiceTicketForm(string selectedLanguage)
        {
            InitializeComponent();
        }

        private void confirmTicketButton_Click(object sender, EventArgs e)
        {
            string serialNumber = serialNumberTextBox.Text;
            string name = nameTextBox.Text;
            string description = descriptionTextBox.Text;

            if (description.Length > 100)
            {
                MessageBox.Show("Too long description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (name.Length < 4)
            {
                MessageBox.Show("Incorrect name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!serialNumber.All(ch => char.IsNumber(ch)) || serialNumber.Length < 4)
            {
                MessageBox.Show("Incorrect serial number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var serviceTicket = ServiceModel.Create(
                serialNumber,
                name,
                description
            );

            serviceTickets.AddServiceTickets(serviceTicket);

            StreamWriter file = new StreamWriter("ServiceTickets.txt", append: true);

            file.WriteLine(serviceTicket.Id + ";" + serviceTicket.SerialNumber + ";" + serviceTicket.Name + ";" + serviceTicket.Description + ";" + serviceTicket.Status);
            file.Close();
        }

        private void AddServiceTicketForm_Load(object sender, EventArgs e)
        {

        }
    }
}

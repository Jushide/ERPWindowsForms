using ERPWindowsForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ERPWindowsForms.Service
{
    public partial class AddServiceTicketForm : Form
    {
        //private readonly ServiceTickets serviceTickets = new ServiceTickets();
        private ListViewItem listViewItem;


        public AddServiceTicketForm(string selectedLanguage)
        {
            InitializeComponent();
            

            //this.serviceTickets = serviceTickets;
            /*row.Text = "" + Guid.NewGuid();
            row.SubItems.Add("2137");
            row.SubItems.Add("Komputer sekretarki");
            row.SubItems.Add("Zapalił się");
            row.SubItems.Add("Pending");
            listView1.Items.Add(row);*/
        }

        private void confirmTicketButton_Click(object sender, EventArgs e)
        {
            string serialNumber = serialNumberTextBox.Text;
            string name = nameTextBox.Text;
            string description = descriptionTextBox.Text;

            if(description.Length > 10 ) 
            {
                MessageBox.Show("Too long description");
            }

            var serviceTicket = ServiceModel.Create(
                serialNumber,
                name,
                description
            );

            label6.Text = serialNumber + ": " + name + " - " + description;

            /*listViewItem.Text = "" + Guid.NewGuid();
            listViewItem.SubItems.Add("2137");
            listViewItem.SubItems.Add("Komputer sekretarki");
            listViewItem.SubItems.Add("Zapalił się");
            listViewItem.SubItems.Add("Pending");

            List<ListViewItem> data = new List<ListViewItem>() { listViewItem };

            // Pass data to Form2
            ServiceForm serviceForm = new ServiceForm("EN");
            serviceForm.ListViewData = data;
            serviceForm.Show();*/
        }

        private void AddServiceTicketForm_Load(object sender, EventArgs e)
        {

        }
    }
}

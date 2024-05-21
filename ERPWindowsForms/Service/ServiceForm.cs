using ERPWindowsForms.Models;
using ERPWindowsForms.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ERPWindowsForms
{
    public partial class ServiceForm : Form
    {
        private static ServiceTickets serviceTickets = new ServiceTickets();
        private string selectedLanguage;
        public static string actionType = "";
        private static string selectedId;

        public List<ListViewItem> ListViewData
        {
            set
            {
                foreach (var row in value)
                {
                    listView1.Items.Add(row);
                }
            }
        }

        public ServiceForm(string selectedLanguage)
        {
            InitializeComponent();
            this.selectedLanguage = selectedLanguage;
            
            if(selectedLanguage=="PL")
            {
                addTicket.Text = "Dodaj zgłoszenie";
                label1.Text = "Serwis";
            }

            /*ListViewItem row = new ListViewItem();
            row.Text=""+Guid.NewGuid();
            row.SubItems.Add("2137");
            row.SubItems.Add("Komputer sekretarki");
            row.SubItems.Add("Zapalił się");
            row.SubItems.Add("Pending");
            listView1.Items.Add(row);*/

            statusComboBox.Items.Add(ServiceStatus.PENDING);
            statusComboBox.Items.Add(ServiceStatus.IN_REALIZATION);
            statusComboBox.Items.Add(ServiceStatus.TO_VERIFY);
            statusComboBox.Items.Add(ServiceStatus.DONE);
            statusComboBox.SelectedIndex = 0;
        }

        private void AddTicket_Click(object sender, EventArgs e)
        {
            //new AddServiceTicketForm(selectedLanguage).Show();
            actionType = "post";
            addTicket.Visible = false;
            label1.Text = "Add ticket";
            listView1.Visible = false;
            goBack.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            serialNumberInput.Visible = true;
            nameInput.Visible = true;
            addTicketButton.Visible = true;
            descInput.Visible = true;
            refreshButton.Visible=false;
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            actionType = "get";
            addTicket.Visible = true;
            if (selectedLanguage == "PL") label1.Text = "Serwis";
            else label1.Text = "Service";
            listView1.Visible = true;
            goBack.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            serialNumberInput.Visible = false;
            nameInput.Visible = false;
            addTicketButton.Visible = false;
            descInput.Visible = false;
            refreshButton.Visible = true;
            label5.Visible = false;
            statusComboBox.Visible = false;
            editTicketButton.Visible = false;
        }

        private void addTicketButton_Click(object sender, EventArgs e)
        {
            string serialNumber = serialNumberInput.Text;
            string name = nameInput.Text;
            string description = descInput.Text;

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

            if (!serialNumber.All(ch => char.IsNumber(ch)) || serialNumber.Length < 1)
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

            ListViewItem row = new ListViewItem();
            row.Text=""+ serviceTicket.Id;
            row.SubItems.Add(serviceTicket.SerialNumber);
            row.SubItems.Add(serviceTicket.Name);
            row.SubItems.Add(serviceTicket.Description);
            row.SubItems.Add(""+serviceTicket.Status);
            listView1.Items.Add(row);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach (var serviceTicket in serviceTickets.GetAllServiceTickets())
            {
                ListViewItem row = new ListViewItem();
                row.Text = "" + serviceTicket.Id;
                row.SubItems.Add(serviceTicket.SerialNumber);
                row.SubItems.Add(serviceTicket.Name);
                row.SubItems.Add(serviceTicket.Description);
                row.SubItems.Add("" + serviceTicket.Status);
                listView1.Items.Add(row);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            actionType = "put";
            addTicket.Visible = false;
            label1.Text = "Edit ticket";
            listView1.Visible = false;
            goBack.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = true;
            serialNumberInput.Visible = false;
            nameInput.Visible = false;
            descInput.Visible = true;
            refreshButton.Visible = false;
            label5.Visible = true;
            statusComboBox.Visible = true;
            editTicketButton.Visible = true;

            

            selectedId = listView1.SelectedItems[0].ToString().Substring(1 + listView1.SelectedItems[0].ToString().IndexOf("{"), 36);

            var serviceTicket = serviceTickets.GetServiceTicket(new Guid(selectedId));
            descInput.Text = serviceTicket.Description;
        }

        private void editTicketButton_Click(object sender, EventArgs e)
        {
            

            string descText = descInput.Text;

            serviceTickets.EditServiceTickets(new Guid(selectedId), statusComboBox.SelectedText, descText);
        }
    }
}

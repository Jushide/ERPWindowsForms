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
    public partial class EditServiceTicket : Form
    {
        private Guid SelectedId;
        private static ServiceTickets serviceTickets = new ServiceTickets();

        public EditServiceTicket(Guid selectedId)
        {
            InitializeComponent();

            SelectedId = selectedId;

            readFromFileAndAddToListView();

            var serviceTicket = serviceTickets.GetServiceTicket(SelectedId);

            statusComboBox.SelectedIndex = 0;
            descTextBox.Text = serviceTicket.Description;
        }

        private void readFromFileAndAddToListView()
        {
            StreamReader file = new StreamReader("ServiceTickets.txt");
            String line = "";
            while ((line = file.ReadLine()) != null)
            {
                string[] data = line.Split(';');

                var serviceTicket = ServiceModel.CreateFromFile(
                    new Guid(data[0]),
                    data[1],
                    data[2],
                    data[3],
                    data[4]
                );

                serviceTickets.AddServiceTickets(serviceTicket);
            }
            file.Close();
        }

        private void editTicket_Click(object sender, EventArgs e)
        {
            string desc = descTextBox.Text;

            serviceTickets.EditServiceTickets(SelectedId, statusComboBox.Text, desc);

            StreamWriter file = new StreamWriter("ServiceTickets.txt");
            foreach (var serviceTicket in serviceTickets.GetAllServiceTickets())
            {
                file.WriteLine(serviceTicket.Id + ";" + serviceTicket.SerialNumber + ";" + serviceTicket.Name + ";" + serviceTicket.Description + ";" + serviceTicket.Status);
            }
            file.Close();
        }
    }
}

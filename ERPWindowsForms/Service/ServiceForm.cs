using ERPWindowsForms.Models;
using ERPWindowsForms.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.Drawing;
using System.Xml.Linq;
using Syncfusion.Pdf.Grid;

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

            readFromFileAndAddToListView();

            pendingRadioButton.Checked = true;
        }

        private void readFromFileAndAddToListView()
        {
            StreamReader file = new StreamReader("ServiceTickets.txt");
            String line = "";
            while ((line = file.ReadLine()) != null)
            {
                string[] data = line.Split(';');
                string[] row = { data[0], data[1], data[2], data[3], data[4] };
                ListViewItem item = new ListViewItem(row);
                listView1.Items.Add(item);

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

        private void AddTicket_Click(object sender, EventArgs e)
        {
            new AddServiceTicketForm(selectedLanguage).Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            readFromFileAndAddToListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedId = listView1.SelectedItems[0].ToString().Substring(1 + listView1.SelectedItems[0].ToString().IndexOf("{"), 36);

            new EditServiceTicket(new Guid(selectedId)).Show();
        }

        private void searchBySerialNumber_Click(object sender, EventArgs e)
        {
            string serialNumber = searchSerialNumber.Text;

            if (serialNumber=="")
            {
                listView1.Items.Clear();
                readFromFileAndAddToListView();
                return;
            }
            else if (serialNumber.Length < 4)
            {
                MessageBox.Show("Incorrect Serial Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ServiceModel serviceTicket  = serviceTickets.GetServiceTicketWithSerialNumber(serialNumber);

            string[] row = { serviceTicket.Id.ToString(), serviceTicket.SerialNumber, serviceTicket.Name, serviceTicket.Description, serviceTicket.Status };
            listView1.Items.Clear();
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }

        private void buildSearchByStatusListView(string statusToSearch)
        {
            listView1.Items.Clear();
            foreach (var serviceTicket in serviceTickets.GetAllServiceTicketsWithGivenStatus(statusToSearch))
            {
                string[] row = { serviceTicket.Id.ToString(), serviceTicket.SerialNumber, serviceTicket.Name, serviceTicket.Description, serviceTicket.Status };
                ListViewItem item = new ListViewItem(row);
                listView1.Items.Add(item);
            }
        }

        private void searchByStatus_Click(object sender, EventArgs e)
        {
            if (pendingRadioButton.Checked)
            {
                buildSearchByStatusListView(pendingRadioButton.Text);
                return;
            }
            else if (inRealizationRadioButton.Checked)
            {
                buildSearchByStatusListView(inRealizationRadioButton.Text);
                return;
            }
            else if (toVerifyRadioButton.Checked)
            {
                buildSearchByStatusListView(toVerifyRadioButton.Text);
                return;
            }
            else if (doneRadioButton.Checked)
            {
                buildSearchByStatusListView(doneRadioButton.Text);
                return;
            }
        }

        private void generatePDF_Click(object sender, EventArgs e)
        {
            List<ServiceModel> serviceTicketsList = serviceTickets.GetAllServiceTicketsWithGivenStatus("DONE");

            PdfDocument doc = new PdfDocument();

            PdfPage page = doc.Pages.Add();

            PdfGrid pdfGrid = new PdfGrid();

            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);

            PdfGraphics graphics = page.Graphics;

            graphics.DrawString("ERP - Service", font, PdfBrushes.Black, new PointF(200, 0));

            graphics.DrawString("Summary of done tasks", new PdfStandardFont(PdfFontFamily.Helvetica, 16), PdfBrushes.Black, new PointF(170, 30));

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Serial Number");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Description");

            foreach (var serviceTicket in serviceTicketsList)
            {
                dataTable.Rows.Add(new object[] { serviceTicket.Id, serviceTicket.SerialNumber, serviceTicket.Name, serviceTicket.Description });
            }

            pdfGrid.DataSource = dataTable;

            pdfGrid.Draw(page, new PointF(10, 60));

            doc.Save("Summary_"+ DateTime.Now.ToString("dd/MM/yyyy/HH/mm") + ".pdf");
            doc.Close(true);
        }
    }
}

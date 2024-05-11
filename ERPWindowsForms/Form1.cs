using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPWindowsForms
{
    public partial class Form1 : Form
    {
        public string choosenLanguage = "EN";

        public Form1()
        {
            InitializeComponent();
            languageSelector.SelectedIndex = 1;
        }

        private void languageSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (languageSelector.SelectedIndex == 0)
            {
                choosenLanguage = "PL";
                label1.Text = "Gratulacje użytkowniku";
                label2.Text = "Wygrałeś okres próbny naszej aplikacji";
                service_button.Text = "Serwis";
            }
            else
            {
                choosenLanguage = "EN";
                label1.Text = "Welcome user";
                label2.Text = "What do you want to do?";
                service_button.Text = "Service";
            }
        }
    }
}

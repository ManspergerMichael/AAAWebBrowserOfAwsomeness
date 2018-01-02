using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAAWebBrowserOfAwsomeness
{
    public partial class mainForm : Form
    {
        public string URL { get; set; }
        public mainForm()
        {
            InitializeComponent();
            webBrowser1.Navigate("http://www.Duckduckgo.com");
        }

        private void toolStripComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(toolStripComboBox1.Text);
                History.Items.Add(toolStripComboBox1.Text); //add website to history
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripComboBox1.Text);
            History.Items.Add(toolStripComboBox1.Text); //add website to history
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = "AAAWebBrowserOfAwsomeness - " + webBrowser1.DocumentTitle;
        }

        private void btnFaves_Click(object sender, EventArgs e)
        {
            if (Faveorites.Visible == true)
            {
                Faveorites.Visible = false;
            }
            else { Faveorites.Visible = true; }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Faveorites.Items.Add(toolStripComboBox1.Text);
        }

        private void Faveorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = Faveorites.SelectedItem.ToString();
            webBrowser1.Navigate(select);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (History.Visible == true)
            {
                History.Visible = false;
            }
            else { History.Visible = true; }
        }
    }
}

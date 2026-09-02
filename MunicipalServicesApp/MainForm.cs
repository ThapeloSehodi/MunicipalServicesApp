using MunicipalServicesApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MunicipalServicesApp.Services;
using MunicipalServicesApp.Forms;

namespace MunicipalServicesApp
{
    public partial class MainForm : Form
    {
        private IssueService issueService;
        public MainForm()
        {
            InitializeComponent();
            issueService = new IssueService();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            ReportIssuesForm reportIssuesForm =
             new ReportIssuesForm(issueService);

            reportIssuesForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using MunicipalServicesApp.Generic;
using MunicipalServicesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp.Services
{
    public class IssueService
    {
        private readonly IssueManager<Issue> issueManager;

        public IssueService()
        {
            issueManager = new IssueManager<Issue>();
        }

        public void AddIssue(Issue issue)
        {
            issueManager.Add(issue);
        }

        public List<Issue> GetAllIssues()
        {
            return issueManager.GetAll();
        }

        public int GetIssueCount()
        {
            return issueManager.Count();
        }

        public List<Issue> SearchIssues(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return issueManager.GetAll();
            }

            searchText = searchText.ToLower();

            return issueManager.GetAll()
    .Where(i =>
        (i.ReferenceNumber ?? "").ToLower().Contains(searchText) ||
        (i.Location ?? "").ToLower().Contains(searchText) ||
        (i.Category ?? "").ToLower().Contains(searchText) ||
        (i.Priority ?? "").ToLower().Contains(searchText) ||
        (i.Status ?? "").ToLower().Contains(searchText))
    .ToList();
        }

        public string GenerateReferenceNumber()
        {
            return "ISS-" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }
    }
}

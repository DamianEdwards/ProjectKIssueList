using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectKIssueList.Models
{
    public class DashboardViewModel
    {
        public string Name { get; set; }

        public List<Build> FailingBuilds { get; set; }

        public List<Build> PassingBuilds { get; set; }

        public string CurrentMilestone { get; set; }

        public int OpenIssuesCount { get; set; }

        public int ClosedIssuesCount { get; set; }

        public int IssuesCount => OpenIssuesCount + ClosedIssuesCount;

        public int OpenPullRequestsCount { get; set; }

        public int StalePullRequestsCount { get; set; }

        public int ClosedPullRequestsCount { get; set; }

        public int PullRequestsCount => OpenPullRequestsCount + ClosedPullRequestsCount;
    }
}

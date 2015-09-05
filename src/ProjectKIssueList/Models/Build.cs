using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectKIssueList.Models
{
    public class Build
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public BuildStatus Status { get; set; }

        public DateTimeOffset Started { get; set; }

        public DateTimeOffset? Ended { get; set; }

        public TimeSpan Duration => (Ended ?? DateTimeOffset.UtcNow) - Started;

        public List<Change> Changes { get; set; } = new List<Change>();

        public int TestsPassed { get; set; }

        public int TestsIgnored { get; set; }

        public int TestsFailed { get; set; }

        public string ErrorMessage { get; internal set; }

        public string Assigneee { get; set; }
    }
}

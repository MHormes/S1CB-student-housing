using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBS03_3_student_housing
{
    class Rules
    {
        private string title;
        private string rule;

        public Rules(string title, string rule)
        {
            Title = title;
            Rule = rule;
        }

        public string Title
        {
            set { this.title = value; }
            get { return title; }
        }

        public string Rule
        {
            set { this.rule = value; }
            get { return rule; }
        }
    }
}

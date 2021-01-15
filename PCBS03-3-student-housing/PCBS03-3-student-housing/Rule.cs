using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBS03_3_student_housing
{
    public class Rule
    {
        public static int CountSeeder = 1;
        private int ruleCounter;
        private string ruleText;

        public int RuleCounter
        {
            get { return this.ruleCounter; }
            set { this.ruleCounter = value; }
        }

        public string RuleText
        {
            set { this.ruleText = value; }
        }
        public Rule(string rule)
        {
            RuleText = rule;
            RuleCounter = CountSeeder;
            CountSeeder++;
        }

  
        public string GetRule()
        {
            return $"{ruleCounter}: {ruleText}";
        }
    }
}

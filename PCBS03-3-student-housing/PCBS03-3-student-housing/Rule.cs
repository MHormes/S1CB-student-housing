using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBS03_3_student_housing
{
    class Rule
    {
        private int ruleCounter = 1;
        private string rule;

        public Rule(string rule)
        {
            this.rule = rule;
        }

  
        public string AssignRuleNumbers()
        {
            return $"{ruleCounter}: {rule}";
            ruleCounter++;
        }
    }
}

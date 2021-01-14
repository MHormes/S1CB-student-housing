using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBS03_3_student_housing
{
    class Rule
    {
        public static int CountSeeder = 1;
        private int ruleCounter;
        private string rule;

        public Rule(string rule)
        {
            this.rule = rule;
            ruleCounter = CountSeeder;
            CountSeeder++;
        }

  
        public string GetRule()
        {
            return $"{ruleCounter}: {rule}";
            
        }
    }
}

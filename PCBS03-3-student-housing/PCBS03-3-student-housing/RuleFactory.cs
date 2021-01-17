using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBS03_3_student_housing
{
    public static class RuleFactory
    {
        public static List<Rule> Seed()
        {
            return new List<Rule>
            {
                new Rule("Don't do this"),
                new Rule("Don't do that"),
                new Rule("Always do this"),
                new Rule("Never do that")
            };
        }
    }
}

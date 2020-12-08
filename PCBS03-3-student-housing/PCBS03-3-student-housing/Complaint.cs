using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBS03_3_student_housing
{
    public class Complaint
    {
        private string complaint;
        private string stName;

        public Complaint(string complaint, string stName)
        {
            this.complaint = complaint;
            this.stName = stName;
        }

        public string GetComplaint()
        {
            return $"{complaint} - {stName}";
        }

        public string GetStName()
        {
            return this.stName;
        }
    }
}

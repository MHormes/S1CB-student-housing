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
        private string adminComment;

        public Complaint(string complaint, string stName)
        {
            this.complaint = complaint;
            StName = stName;
        }

        public string AdminComment
        {
            set { this.adminComment = value; }
            get { return this.adminComment; }
        }

        public string StName
        {
            private set { this.stName = value; }
            get { return this.stName; }
        }

        public string GetComplaint()
        {
            if (String.IsNullOrWhiteSpace(adminComment))
            {
                return $"{complaint}";
            }
            return $"{complaint} - admin: ({adminComment})";
        }  
    }
}

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
            this.stName = stName;
        }

        public string GetComplaint()
        {
            if (String.IsNullOrWhiteSpace(adminComment))
            {
                return $"{complaint}";
            }
            return $"{complaint} - admin: ({adminComment})";
        }

        public string GetStName()
        {
            return this.stName;
        }

        public void SetAdminComment(string comment)
        {
            this.adminComment = comment;
        }

        public string GetAdminComment()
        {
            return this.adminComment;
        }
    }
}

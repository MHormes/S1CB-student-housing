using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBS03_3_student_housing
{
    public class Announcement
    {
        private string message;
        private string author;

        public Announcement(string news, string name)
        {
            message = news;
            author = name;
        }

        public string GetAnnouncement()
        {
            return $"{message} - {author}";
        }
    }
}

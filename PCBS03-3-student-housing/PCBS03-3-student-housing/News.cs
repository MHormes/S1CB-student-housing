using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBS03_3_student_housing
{
    public class News
    {
        private string message;
        private string author;

        public News(string news, string name)
        {
                message = news;
                author = name;
        }

        public string GetNews()
        {
            return $"{message} - {author}";
        }
    }
}

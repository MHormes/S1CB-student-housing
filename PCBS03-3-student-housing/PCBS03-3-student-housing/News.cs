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

/*       old method to make news object. Can still be used if the null or whitespace cheking needs to be inside of the class instead of the form
 *       public bool SetNews(string news, string name)
        {
            if(!String.IsNullOrWhiteSpace(news) && !String.IsNullOrWhiteSpace(name))
            { 
                message = news;
                author = name;
                return true;
            }
            else
            {
                return false;
            }
        }*/

        public string GetNews()
        {
            return $"{message} - {author}";
        }
    }
}

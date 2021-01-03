using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBS03_3_student_housing
{
    public class Student
    {
        private List<Tuple<string, string>> studentList = new List<Tuple<string, string>>();

        //add student method (name, password)
        public void addStudent(string studentName, string studentPassword)
        {
            studentList.Add(Tuple.Create(studentName, studentPassword));
        }

        //only name needed, remove student method
        public void removeStudent(string studentName)
        {
            //index of the element finded
            int index = 0;
            foreach(Tuple<string, string>  element in studentList)
            {
                if (element.Item1 == studentName)
                    index = studentList.IndexOf(element);
            }
            //item removed at the index finded
            studentList.RemoveAt(index);
        }

        public bool itContainsStudent(string studentName)
        {
            //bool to check if the student is present in the list
            bool itContains = false;
            foreach (Tuple<string, string> element in studentList)
            {
                if (element.Item1 == studentName)
                    itContains = true;
            }
            return itContains;
        }

        //student list returned
        public List<Tuple<string, string>> getStudentList()
        {
            return studentList;
        }
    }
}

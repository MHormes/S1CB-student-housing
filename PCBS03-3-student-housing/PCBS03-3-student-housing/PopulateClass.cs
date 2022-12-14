using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBS03_3_student_housing
{
    public static class PopulateClass
    {
        public static int Counter;

        public static List<Rule> SeedRule()
        {
            return new List<Rule>
            {
                new Rule("Make sure to turn off lights when you have left the house."),
                new Rule("Smoking is not allowed inside the house."),
                new Rule("Make sure the rooms get ventilated to prevent mold growth."),
                new Rule("Do not flush foreign items down the toilet.")
            };
        }

        public static void SeedStudent()
        {
            Student.addStudent("Alessandro", "12345");
            Student.addStudent("Luca", "12345");
            Student.addStudent("Maarten", "12345");
        }

        public static void SeedComplaint()
        {
            studentForm.complaintStudentList.Add(new Complaint("Maarten is way too loud.", "Luca"));
            studentForm.complaintStudentList.Add(new Complaint("Alessandro never cleans.", "Maarten"));
            studentForm.complaintStudentList.Add(new Complaint("Luca never flushes the toilet.", "Alessandro"));
            Counter++;
        }

        public static void SeedNewsList()
        {
            adminForm.newsList.Add(new News("Welcome to our application. Below is explained what is hard coded for this demo", ""));
            adminForm.newsList.Add(new News("There have been made 3 student accounts (Alessandro, Luca and Maarten)", ""));
            adminForm.newsList.Add(new News("Besides these users there are multiple rules, complaints, news items and announcements to find", ""));
        }

        public static void SeedAnnouncements()
        {
            studentForm.announcementList.Add(new Announcement("I will be on holiday till 07/02, so won't do my tasks", "Alessandro"));
            studentForm.announcementList.Add(new Announcement("The trash wasn't take out today", "Luca"));
            studentForm.announcementList.Add(new Announcement("I will host a party on 27/01", "Maarten"));
        }
    }
}

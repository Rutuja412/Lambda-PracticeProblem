using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Practice_Problem
{
    public class LambdaOperationW
    {
        public static void StidentsAgeBetween12to18(List<Student> students)
        {
            Console.WriteLine("Age Records");
             List<Student> AgeRecords = students.Where(s => s.Age >= 12 && s.Age <= 18).ToList();
            Program.Display(AgeRecords);

        }
        //Sort students data in descending order based on TotalMarks.
        public static void SortBasedOnMarks(List<Student> students)
        {
            Console.WriteLine("Sort students data in descending order based on TotalMarkks");
            List<Student> TotalMarks = students.OrderByDescending(s => s.TotalMarks).ToList();
            Program.Display(TotalMarks);

        }
        //Display all the student records in each address.
        public static void ShowAddressRecord(List<Student> students)
        {
            Console.WriteLine("Address Records");
            List<Student>AddressRecord=students.OrderBy(s => s.Address).ToList();
            Program.Display(AddressRecord);
           
           
        }
        //Fetch first three students records.
        public static void CheckFirst3Records(List<Student> students)
        {
            Console.WriteLine("Top 3 records");
           List<Student> Top3 = students.Take(3).ToList();
            Program.Display(Top3);

        }

    }
}

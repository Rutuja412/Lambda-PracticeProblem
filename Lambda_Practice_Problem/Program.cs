﻿using System;
using System.Collections.Generic;

namespace Lambda_Practice_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lambda_Practice_Problem!");
            Student student1 = new Student();
            List<Student> list = new List<Student>()
            {
                // Id, Name, Phone Number, Address and Age fields.
                new Student() { Id = 1, Name = "Rutuja", PhoneNumber = "9011973870", Address = "Satara", Age = 23,TotalMarks=95 },
                new Student() { Id = 2, Name = "Snehal", PhoneNumber = "9011973456", Address = "Satara", Age = 12,TotalMarks=98},
                new Student() { Id = 3, Name = "Kajal", PhoneNumber = "9011973878", Address = "Satara", Age = 25 ,TotalMarks=55 },
                new Student() { Id = 4, Name = "Pooja", PhoneNumber = "9011973874", Address = "Satara", Age = 14 ,TotalMarks=100 },
                new Student() { Id = 5, Name = "Radhika", PhoneNumber = "9011973816", Address = "Satara", Age = 18 ,TotalMarks = 55 },
            };
            Display(list);

        }
        public static void Display(List<Student> list)
        {
            Console.WriteLine("Displayind Detailss");
            foreach (Student student in list)
            {

                Console.WriteLine("ID :" + student.Id + "  " + "Name :" + student.Name + "  " + "Phone Number :" + student.PhoneNumber + "  " + "Address :" + student.Address + "  " + "Age :" + student.Age + " " + "TotalMarks : " + student.TotalMarks);

            }
        }
    }
}

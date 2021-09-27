using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Classes
{
    public class Student
    {
        public int SoonerID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsOnProbation { get; set; }

        public double GPA { get; set; }

        private double BursarBalance;

        public Student()
        {
            SoonerID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            IsOnProbation = false;
            GPA = 0;
            BursarBalance = 0;
        }

        public Student(int id, string fName, string LName, double bursarBalance)
        {
            SoonerID = id;
            FirstName = fName;
            LastName = LName;
            IsOnProbation = false;
            GPA = 0;
            BursarBalance = bursarBalance;
        }

        public void MakePayment (double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Invalid");
                //throw new Exception("amount must be greater than 0");
            }

            BursarBalance -= amount;
        }

        public double CheckBalance()
        {
            return BursarBalance;
        }
    }
}

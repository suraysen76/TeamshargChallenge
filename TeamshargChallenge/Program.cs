using System;
using TeamshargChallenge.Model;

namespace TeamshargChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            var employee = new EmployeeModel() { Name = "John Doe", JobTitle = "Software Developer" };
            Logic.PrintDetails(employee);
        }
    }
}

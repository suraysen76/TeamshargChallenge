using System;
using System.Collections.Generic;
using System.Text;
using TeamshargChallenge.Model;

namespace TeamshargChallenge
{
    public static class Logic
    {
        public static void PrintDetails(EmployeeModel model)
        {
            Console.WriteLine("Name : {0}, JobTitle : {1}", model.Name, model.JobTitle);
        }
    }
}

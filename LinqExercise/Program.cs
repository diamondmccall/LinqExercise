﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            var sum = numbers.Sum();
            Console.WriteLine($"{sum}");

            Console.WriteLine($"------------");

            //TODO: Print the Average of numbers
            var average = numbers.Average();
            Console.WriteLine($"{average}");

            Console.WriteLine($"------------");

            //TODO: Order numbers in ascending order and print to the console
            var ascend = numbers.OrderBy(num => num);
            foreach (var ascends in ascend)
            {
                Console.WriteLine($"{ascends}");
            }
            Console.WriteLine($"------------");

            //TODO: Order numbers in decsending order and print to the console
            var decsend = numbers.OrderByDescending(numx => numx);
            foreach (var decsends in decsend)
            {
                Console.WriteLine($"{decsends}");
            }
            Console.WriteLine($"------------");

            //TODO: Print to the console only the numbers greater than 6
            var greaterThanSix = numbers.Where(i => i >= 6);
            foreach (var greaters in greaterThanSix)
            {
                Console.WriteLine($"{greaters}");
            }
            Console.WriteLine($"------------");

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            var four = numbers.OrderByDescending(f => f).Where(f => f < 4);
            foreach (var fours in four )
            {
                Console.WriteLine($"{fours}");
            }
            Console.WriteLine($"------------");


            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            numbers [4] = 30;
            foreach (var age in numbers.OrderByDescending(num => num))
            {
                Console.WriteLine($"{age}");
            }
            Console.WriteLine($"------------");


            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var filter = employees.Where(person => person.FirstName.StartsWith('C') || person.FirstName.StartsWith('S')).OrderBy(person => person.FirstName);
            foreach (var filters in filter)
                
            {
                Console.WriteLine($"{filters.FullName}");
            }
            Console.WriteLine($"------------");

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var ageName = employees.Where(person => person.Age >= 26);
            foreach (var agenNames in ageName)
            {
                Console.WriteLine($"{agenNames.Age} && {agenNames.FullName}");
            }
            Console.WriteLine($"------------");

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var experienceSum = employees.Where(employees => employees.YearsOfExperience <= 10 && employees.Age > 35);
            var sumOfYears = experienceSum.Sum(employees => employees.YearsOfExperience);
            var aveOfYears = experienceSum.Average(employees => employees.YearsOfExperience);
            {
                Console.WriteLine($"{sumOfYears} , {aveOfYears}");
            }
            Console.WriteLine($"------------");

            //TODO: Add an employee to the end of the list without using employees.Add()

            employees = employees.Append(new Employee("Diamond", "Mccall", 30, 1)).ToList();
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} {item.Age} {item.YearsOfExperience}");
            }


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}

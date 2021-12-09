using System;
using System.Collections.Generic;

namespace empLibs{


    public class Employee{
        
        //attributes
        private string name;
        private double hourly_rate;
        private double salary;
        
        //constructor
        public Employee(string nm, double hr, double sal){
            
            this.Name = nm;
            this.Hourly_rate = hr;
            this.Salary = sal;
            
        }

        //public Employee(){}

        //get and set
        public string Name{
            
            get { return this.name; }
            set { this.name = value; }
        }
        
 
        public double Hourly_rate{
            
            get { return this.hourly_rate; }
            set { this.hourly_rate = value; }
        }
        
        public double Salary{
            
            get { return this.salary; }
            set { this.salary = value; }
        }
           

        public double SalaryHour(int hour){

            double salary_hour = 0;

            salary_hour = hour * hourly_rate;

            double sal_final = salary + salary_hour;



            return sal_final;


        }



    } // Employee







    class Program {
        static void Main() {

            int nm_hours;

            Employee emp1 = new Employee("Bob", 8, 1300);
            Employee emp2 = new Employee("Tim", 10, 1500);

            Console.WriteLine("The employee {0} earns {1} $/hour and has a salary base of {2} ", emp1.Name, emp1.Hourly_rate, emp1.Salary);

            Console.WriteLine("The employee {0} earns {1} $/hour and has a salary base of {2} ", emp2.Name, emp2.Hourly_rate, emp2.Salary);
        
            Console.WriteLine("Write the number of hour worked: ");
            nm_hours = int.Parse(Console.ReadLine());

            Console.WriteLine("the employee {0} has a final salary of {1} ", emp1.Name, emp1.SalaryHour(nm_hours));
            Console.WriteLine("the employee {0} has a final salary of {1} ", emp2.Name, emp2.SalaryHour(nm_hours));

        }
    }




}
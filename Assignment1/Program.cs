using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Nidhi", 777, 10);
            Console.WriteLine(o1.Name + " " + o1.EmpNo + " " + o1.Basic + " " + o1.DeptNo);
            Console.WriteLine("Salary is:" + o1.getSalary());

            Employee o2 = new Employee("Nidhi", 555);
            Console.WriteLine(o2.Name + " " + o2.EmpNo);
            // Console.WriteLine("Salary is:"+o2.getSalary());

            Employee o3 = new Employee("Nidhi");
            Console.WriteLine(o3.Name);

            Employee o4 = new Employee();
            // Console.WriteLine(o4.Name + "" + o4.EmpNo + " " + o4.Basic + " " + o4.DeptNo);


            Console.ReadLine();

        }

        class Employee
        {
            private String name;
            public String Name
            {
                set
                {
                    if (name == "")
                        Console.WriteLine("invalid string");
                    else
                        name = value;
                }
                get
                {
                    return name;
                }
            }
            int emoNo;
            public int EmpNo
            {
                get
                {
                    return empNo = 1;
                }
            }
            private decimal basic;
            public decimal Basic
            {
                set
                {
                    if (value > 0 && value < 1000)
                        basic = value;
                    else
                        Console.WriteLine("enter valid data");
                    Console.WriteLine();
                }

                get
                {
                    return basic;
                }
            }

            private short deptNo;
            private int empNo;

            public decimal DeptNo
            {
                set
                {
                    if (value > 0)
                        deptNo = (short)value;
                    else
                        Console.WriteLine("enter valid data");
                    Console.WriteLine();
                }

                get
                {
                    return deptNo;
                }
            }



            public Employee(String name, Decimal basic, short deptNo)
            {
                this.Name = name;
                emoNo++;
                this.Basic = basic;
                this.DeptNo = deptNo;
            }

            public Employee(String name, Decimal basic)
            {
                this.Name = name;
                emoNo++;
                this.Basic = basic;
            }

            public Employee(String name)
            {
                this.Name = name;
                emoNo++;
            }
            public Employee()
            {
                emoNo++;
            }



            public decimal getSalary()
            {

                return basic + 1000;

            }


        }
    }
}
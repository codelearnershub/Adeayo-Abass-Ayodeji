using System;
using System.Collections.Generic;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Register> Students = new List<Register>();

            string course1 = "";
            string institution1 = "";
            string registrationNum = "";

            bool IsRegister = false;

            Console.Write("\nEnter your birth year to proceed (e.g 1992): ");
            int yearOfBirth = int.Parse(Console.ReadLine());
            int age = DateTime.Now.Year - yearOfBirth;


            if (age < 18)
            {
                Console.Write("Sorry! Your age is too low to proceed this registration...");
            }


            while (!IsRegister && age >= 18)
            {
                Console.WriteLine("WELCOME TO JAMB APP....");


                Console.Write(
                    "Enter '1' to register\n enter '2' to check Admission status\n enter '3' to update status\n " +
                    "enter '4' to Admit students\n enter '5' to exit. ");
                int response = int.Parse(Console.ReadLine());

                if (response == 1)
                {
                    Console.Write("Enter your First Name: ");
                    string firstName = Console.ReadLine().ToUpper();

                    Console.Write("Enter your Last Name: ");
                    string lastName = Console.ReadLine().ToUpper();

                    Console.Write("Enter your Middle Name: ");
                    string middleName = Console.ReadLine().ToUpper();

                    Console.Write("Enter Institution: ");
                    string institution = Console.ReadLine().ToUpper();

                    Console.Write("Enter your Gender (\"F\" for Female or \"M\" for Male): ");
                    string gender = Console.ReadLine().ToUpper();
                    Console.Write("Enter course: ");
                    string course = Console.ReadLine().ToUpper();

                    var student1 = new Register(firstName, lastName, middleName, institution, course, gender, age,
                        GenerateRegNo());
                    Console.WriteLine(
                        $"Applicant {firstName} {lastName} {middleName}. You have successfully registered " +
                        $"for your JAMB and your registration number is {GenerateRegNo()}");
                    Students.Add(student1);

                    static string GenerateRegNo()
                    {
                        Random studentReg = new Random();

                        return
                            $"JM{studentReg.Next(1, 1000).ToString("0000")}{(char) ('A' + studentReg.Next(26))}{(char) ('A' + studentReg.Next(26))}";
                    }
                }
                else if (response == 2)
                {
                    Console.Write("Enter your registration number: ");
                    string regNo = Console.ReadLine().Trim();
                    bool check = false;

                    foreach (var item in Students)
                    {
                        if (item.GetIsAdmitted() == true)
                        {
                            Console.WriteLine(
                                $"Congratulations! You have been offered admission into {institution1} to study {course1}");
                            check = true;
                        }
                        
                    }

                    if (!check)
                    {
                        Console.Write("Sorry! You haven't been admitted. You may check later");
                    }
                }
                else if (response == 3)
                {
                    Console.Write("Enter your registration number to update your info: ");
                    string regUpdate = Console.ReadLine();

                    foreach (var item in Students)
                    {
                        if ((item.RegNo) == regUpdate)
                        {
                            Console.Write("Enter '1' to update your First Name\n Enter '2' to update your Last Name\n Enter '3' to  your MiddleName\n Enter " +
                                          "'4' to update your Year of Birth\n Enter '5 to update your Course\n Enter '6' to update Gender\n " +
                                          "Enter '7' to update your Institution\n");
                            int updateResponse = int.Parse(Console.ReadLine());

                            if (updateResponse == 1)
                            {
                                Console.Write("Enter your First Name: ");
                                item.FirstName = Console.ReadLine().ToUpper();
                                
                                foreach (var firstName in Students)
                                {
                                    Console.Write($"You have successfully updated your gender from {firstName} to {item.FirstName}");
                                }
                            }

                            if (updateResponse == 2)
                            {
                                Console.Write("Enter your Last Name: ");
                                item.LastName = Console.ReadLine().ToUpper();
                                
                                foreach (var lastName in Students)
                                {
                                    Console.Write($"You have successfully updated your gender from {lastName} to {item.LastName}");
                                }
                            }

                            if (updateResponse == 3)
                            {
                                Console.Write("Enter your Last Name: ");
                                item.Middlename = Console.ReadLine().ToUpper();
                                
                                foreach (var middleName in Students)
                                {
                                    Console.Write($"You have successfully updated your gender from {middleName} to {item.Middlename}");
                                }
                            }

                            if (updateResponse == 4)
                            {
                                Console.Write("Enter your Year of birth: ");
                                item.YearOfBirth = int.Parse(Console.ReadLine());
                                
                                foreach (var birth in Students)
                                {
                                    Console.Write($"You have successfully updated your gender from {yearOfBirth} to {item.YearOfBirth}");
                                }
                            }

                            if (updateResponse == 5)
                            {
                                Console.Write("Enter your Course: ");
                                item.Course = Console.ReadLine().ToUpper();
                                
                                Console.Write($"You have successfully updated from {course1} to {item.Course}");
                            }

                            if (updateResponse == 6)
                            {
                                Console.Write("Update your Gender (\"F\" for Female or \"M\" for Male): ");
                                item.Gender = Console.ReadLine().ToUpper();
                                foreach (var gender in Students)
                                {
                                    Console.Write($"You have successfully updated your gender from {gender} to {item.Gender}");
                                }
                                
                            }

                            if (updateResponse == 7)
                            {
                                Console.Write("Update your Institution: ");
                                item.Institution = Console.ReadLine().ToUpper();
                            }

                            else if (updateResponse == 7 || updateResponse == 5)
                            {
                                foreach (var student in Students)
                                {
                                    if (student.Course == course1 || student.Institution == institution1)
                                    {
                                        student.SetIsAdmitted(true);
                                    }
                                }
                            }
                        }
                    }
                }

                if (response == 4)
                {
                    Console.Write(
                        "Enter '1' to Admit by Registration Number\n Enter '2' to Admit by Course\n Enter '3' to Admit by Institution: ");
                    int admitResponse = int.Parse(Console.ReadLine());

                    if (admitResponse == 1)
                    {
                        Console.Write("Enter Registration Number of the Aspirant: ");
                        registrationNum = Console.ReadLine();
                    }

                    if (admitResponse == 2)
                    {
                        Console.Write("Enter Aspirant's Course: ");
                        course1 = Console.ReadLine().ToUpper();
                    }

                    if (admitResponse == 3)
                    {
                        Console.Write("Enter Institution: ");
                        institution1 = Console.ReadLine().ToUpper();
                    }

                    foreach (var item in Students)
                    {
                        if (item.RegNo == registrationNum || item.Course == course1 || item.Institution == institution1)
                        {
                            item.SetIsAdmitted(true);
                        }
                    }

                    foreach (var item in Students)
                    {
                    }
                }

                if (response == 5)
                {
                    IsRegister = false;
                }
            }
        }
    }
}
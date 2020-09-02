using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3
{
    class Student
    {
        public String studentID;
        public String firstName;
        public String lastName;
        public String major;
        public String phoneNumber;
        private double gpa;
        public String dateOfBirth;

        public String StudentID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Major { get; set; }
        public String PhoneNumber { get; set; }
        public double Gpa
        {
            get
            {
                return gpa;
            }

            set
            {
                if (value < 0 || value > 4.0)
                {
                    gpa = 0;
                }
                else
                {
                    gpa = value;
                }

            }

        }

        public String DateOfBirth { get; set; }
        public Student(String SID, String fName, String lName, String major, String phoneNumber, double GPA, string Dob)
        {
            StudentID = SID;
            FirstName = fName;
            LastName = lName;
            Major = major;
            PhoneNumber = phoneNumber;
            Gpa = GPA;
            DateOfBirth = Dob;
        }

        public override string ToString()
        {
            String data = "Student ID =======> " + StudentID + "\n";
            data += "First Name =======> " + FirstName + "\n";
            data += "Last Name ========> " + LastName + "\n";
            data += "Major =======> " + Major + "\n";
            data += "Phone Number =======> " + PhoneNumber + "\n";
            data += "GPA ==============> " + Gpa + "\n";
            data += "Date Of Birth =======> " + DateOfBirth + "\n";
            return data;

        }

        static void Main(string[] args)
        {
            string temp; int size;

            WriteLine("How many Students you would like to enter the data: ");
            size = Convert.ToInt32(ReadLine());

            Student[] studentList = new Student[size];
            GetStudentInfo(studentList, 1);

            PrintList(studentList);

            WriteLine("Enter the Student ID you want to modify: ");
            temp = ReadLine();
            Student modify = ModifyBySID(studentList, temp);

            Student search = StudentSearch(studentList);

            ReadLine();
        }

        static void PrintList(Student[] students)
        {
            foreach (Student student in students)
            {
                WriteLine(student);
            }
        }

        static Student GetStudentInfo(Student[] students, int index)
        {
            WriteLine("Please enter the Student ID: ");
            string stuId = ReadLine();

            WriteLine("Please enter the Student first name: ");
            string sfname = ReadLine();

            WriteLine("Please entert the Student last name: ");
            string slname = ReadLine();

            WriteLine("Please enter the major Student study in: ");
            string smajor = ReadLine();

            WriteLine("Please enter the Student phone number: ");
            string sph = ReadLine();

            WriteLine("Please enter the Student GPA: ");
            double sgpa = Convert.ToDouble(ReadLine());

            WriteLine("Please enter the Student Date of Birth: ");
            string sdob = ReadLine();

            students[index] = new Student(stuId, sfname, slname, smajor, sph, sgpa, sdob);
            return students[index];
        }

        static Student ModifyBySID(Student[] students, string SID)
        {
            bool found = false;
            int index = -1;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].StudentID.Equals(SID))
                {
                    found = true;
                    index = i;
                }
            }

            if (found)
            {
                Student studentInfo = students[index];
            }

            WriteLine("Please enter the number you want to modify: \n 1. Student ID \n 2. Student First Name \n 3. Student Last Name \n 4. Major \n 5. Phone \n 6. GPA \n 7. Date of Birth \n");
            string num = ReadLine();

            if (num == "1")
            {
                WriteLine("Please enter the update Student ID: ");
                string updateId = ReadLine();
                data.txt = students[index].StudentID.ToString();
            }
            else if (num == "2")
            {
                WriteLine("Please enter the update Student First Name: ");
                string updateFname = ReadLine();
                data.txt = students[index].firstName.ToString();
            }
            else if (num == "3")
            {
                WriteLine("Please enter the update Student Last Name: ");
                string updateLname = ReadLine();
                data.txt = students[index].lastName.ToString();
            }
            else if (num == "4")
            {
                WriteLine("Please enter the update major Student study in: ");
                string updateMajor = ReadLine();
                data.txt = students[index].major.ToString();
            }
            else if (num == "5")
            {
                WriteLine("Please enter the update Student phone number: ");
                string updatePh = ReadLine();
                data.txt = students[index].PhoneNumber.ToString();
            }
            else if (num == "6")
            {
                WriteLine("Please enter the update Student GPA: ");
                double updateGpa = Convert.ToDouble(ReadLine());
                data.txt = students[index].Gpa.ToString();
            }
            else if (num == "7")
            {
                WriteLine("Please enter the update Student Date of Birth: ");
                string updateDob = ReadLine();
                data.txt = students[index].DateOfBirth.ToString();
            }
            else
            {
                WriteLine("You are enter invalid number.");
            }
            return students[index];
        }
    }


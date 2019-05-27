using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public Universities University { get; set; }
        public Faculties Faculty { get; set; }
        public Specialties Specialty { get; set; }

        public Student(string firstName, string middleName, string lastName, int ssn, string address, string phoneNumber, string email,
    string course, Universities university, Faculties faculty, Specialties specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student == null)
            {
                return false;
            }
            if (student.FirstName == this.FirstName && student.MiddleName == this.MiddleName && student.LastName == this.LastName &&
                student.SSN == this.SSN && student.Address == this.Address && student.PhoneNumber == this.PhoneNumber &&
                student.Email == this.Email && student.Course == this.Course && student.Specialty == this.Specialty &&
                student.University == this.University && student.Faculty == this.Faculty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("First name: " + this.FirstName);
            builder.AppendLine("Middle name: " + this.MiddleName);
            builder.AppendLine("Last name: " + this.LastName);
            builder.AppendLine("SSN: " + this.SSN);
            builder.AppendLine("Address: " + this.Address);
            builder.AppendLine("Phone number: " + this.PhoneNumber);
            builder.AppendLine("Email: " + this.Email);
            builder.AppendLine("Course: " + this.Course);
            builder.AppendLine("University: " + this.University);
            builder.AppendLine("Faculty: " + this.Faculty);
            builder.AppendLine("Speciality: " + this.Specialty);

            return builder.ToString();
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(Student.Equals(firstStudent, secondStudent));
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Student Clone()
        {
            Student result = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.PhoneNumber, this.Email, this.Course, this.University, this.Faculty, this.Specialty);

            return result;
        }

        public int CompareTo(Student currentStudent)
        {
            int firstNameCompare = this.FirstName.CompareTo(currentStudent.FirstName);

            if (firstNameCompare != 0)
            {
                return firstNameCompare;
            }
            else
            {
                int middleNameCompare = this.MiddleName.CompareTo(currentStudent.MiddleName);

                if (middleNameCompare != 0)
                {
                    return middleNameCompare;
                }
                else
                {
                    int lastNameCompare = this.LastName.CompareTo(currentStudent.LastName);

                    if (lastNameCompare != 0)
                    {
                        return lastNameCompare;
                    }
                    else
                    {
                        int SSNCompare = this.SSN.CompareTo(currentStudent.SSN);

                        if (SSNCompare != 0)
                        {
                            return SSNCompare;
                        }

                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

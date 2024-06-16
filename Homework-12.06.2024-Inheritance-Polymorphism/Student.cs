using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12._06._2024_Inheritance_Polymorphism
{
    class Student
    {
        protected string? name;
        protected string? lastName;
        protected string? patronymic;
        protected DateOnly dateOfBirth;
        protected string? homeAdres;
        protected string? phoneNumber;
        protected readonly List<int> tests = [];
        protected readonly List<int> courseWorks = [];
        protected readonly List<int> exams = [];
        protected string? speciality;

        public Student() : this("Ivan", "Ivanovich", "Ivanov", new DateOnly(2000, 01, 01), "str.Bolharskaya, 87", "+38(068)1234567", "Software Developer") {}

        public Student(string? name, string? lastName) :
            this(name, "Ivanovich", lastName, new DateOnly(2000, 01, 01), "Home Adres", "Phone Number", "Software Developer"){}

        public Student(string? name, string? patronymic, string? lastName) :
            this(name, lastName, patronymic, new DateOnly(2000, 01, 01), "Home Adres", "Phone Number", "Software Developer"){}

        public Student(string? name, string? lastName, DateOnly dateOfBirth, string? phoneNumber) :
            this(name, "Patronymic", lastName, dateOfBirth, "Home Adres", phoneNumber, "Software Developer"){}

        public Student(string? name, string? patronymic, string? lastName, DateOnly dateOfBirth, string? homeAdres, string? phoneNumber, string? speciality)
        {
            SetName(name);
            SetPatronymic(patronymic);
            SetLastName(lastName);
            SetDateOfBirth(dateOfBirth);
            SetHomeAdres(homeAdres);
            SetPhoneNumber(phoneNumber);
            SetSpeciality(speciality);
        }

        public void SetName(string? name)
        {
            this.name = name;
        }
        public void SetLastName(string? lastName)
        {
            this.lastName = lastName;
        }
        public void SetPatronymic(string? patronymic)
        {
            this.patronymic = patronymic;
        }
        public void SetDateOfBirth(DateOnly dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }
        public void SetHomeAdres(string? homeAdres)
        {
            this.homeAdres = homeAdres;
        }
        public void SetPhoneNumber(string? phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public void SetSpeciality(string? speciality)
        {
            this.speciality = speciality;
        }
        public string? GetSpeciality()
        {
            return speciality;
        }

        public string? GetName()
        {
            return name;
        }
        public string? GetLastName()
        {
            return lastName;
        }
        public string? GetPatronymic()
        {
            return patronymic;
        }
        public DateOnly GetDateOfBirth()
        {
            return dateOfBirth;
        }
        public string? GetHomeAdres()
        {
            return homeAdres;
        }
        public string? GetPhoneNumber()
        {
            return phoneNumber;
        }

        public override string ToString()
        {
            string? strings = "\tStudent Info: \n\n";
            strings += "Speciality: \t" + speciality + "\n";
            strings += "Name: \t\t" + name + "\n";
            strings += "Last name: \t" + lastName + "\n";
            strings += "Patronymic: \t" + patronymic + "\n";
            strings += "Date of birth: \t" + dateOfBirth + "\n";
            strings += "Home adres: \t" + homeAdres + "\n";
            strings += "Phone number: \t" + phoneNumber + "\n";
            strings += "Tests: \t\t";

            foreach (var test in tests)
            {
                strings += test + " ";
            }
            strings += " Average: " + tests.Average() + "\n";

            strings += "Course works: \t";
            foreach (var courseWork in courseWorks)
            {
                strings += courseWork + " ";
            }
            strings += " Average: " + courseWorks.Average() + "\n";

            strings += "Exams: \t\t";
            foreach (var exam in exams)
            {
                strings += exam + " ";
            }
            strings += " Average: " + exams.Average() + "\n";
            strings += "Total Average:  " + AverageRatings() + "\n";

            return strings;
        }

        public virtual void Study()
        {
            Console.WriteLine("Student " + name + " " + LastName + " studyes programming in C# language\n");
        }

        public virtual void TakeExam()
        {
            Console.WriteLine("Student " + name + " " + LastName + " passed the exams with " + exams.Average() + " points\n");
        }

        public void AddTestsRatings(int rating)
        {
            tests.Add(rating);
        }

        public void AddCourseWorksRatings(int rating)
        {
            courseWorks.Add(rating);
        }

        public void AddExamsRatings(int rating)
        {
            exams.Add(rating);
        }

        public void RemoveTestsRatings(int rating)
        {
            tests.Remove(rating);
        }

        public void RemoveCourseWorksRatings(int rating)
        {
            courseWorks.Remove(rating);
        }

        public void RemoveExamsRatings(int rating)
        {
            exams.Remove(rating);
        }

        public double AverageRatings()
        {
            
            if (tests.Count == 0 || courseWorks.Count == 0 || exams.Count == 0)
            {
                return 0;
            }

            double avg = (tests.Average() + courseWorks.Average() + exams.Average()) / 3;
            return Math.Round(avg, 2);
        }

        //////////////////////////            OVERLOAD            //////////////////////////////////////////////

        public static bool operator <(Student left, Student right)
        {
            return left.AverageRatings() < right.AverageRatings();
        }

        public static bool operator >(Student left, Student right)
        {
            return !(left < right);
        }

        public static bool operator true(Student student)
        {
            return student.AverageRatings() >= 10;
        }

        public static bool operator false(Student student)
        {
            return student.AverageRatings() < 10;
        }

        public static bool operator ==(Student left, Student right)
        {
            return left.AverageRatings() == right.AverageRatings();
        }

        public static bool operator !=(Student left, Student right)
        {
            return !(left == right);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Student student)
            {
                return this == student;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return AverageRatings().GetHashCode();
        }

        //////////////////////////            PROPERTIES            //////////////////////////////////////////////
        
        public string? Speciality
        {
            get
            {
                return speciality;
            }
            set
            {
                speciality = value;
            }
        }

        public string? Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string? LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string? Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                patronymic = value;
            }
        }

        public DateOnly DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
            }
        }

        public string? HomeAddress
        {
            get
            {
                return homeAdres;
            }
            set
            {
                homeAdres = value;
            }
        }

        public string? PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
    }
}

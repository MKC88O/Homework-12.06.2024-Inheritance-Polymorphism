using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12._06._2024_Inheritance_Polymorphism
{
    class Aspirant : Student
    {
        private string? thesisTheme;
        public Aspirant() : base("Ivan", "Ivanovich", "Ivanov", new DateOnly(2000, 01, 01), "str.Bolharskaya, 87", "+38(068)1234567", "Software Developer") {}

        public Aspirant(string? thesisTheme) :
            base("Ivan", "Ivanovich", "Ivanov", new DateOnly(2000, 01, 01), "str.Bolharskaya, 87", "+38(068)1234567", "Software Developer")
        {
            this.thesisTheme = thesisTheme;
        }

        public Aspirant(string? name, string? lastName) :
            base(name, "Ivanovich", lastName, new DateOnly(2000, 01, 01), "str.Bolharskaya, 87", "+38(068)1234567", "Software Developer"){}

        public Aspirant(string? name, string? lastName, string? thesisTheme) :
            base(name, "Ivanovich", lastName, new DateOnly(2000, 01, 01), "str.Bolharskaya, 87", "+38(068)1234567", "Software Developer")
        {
            this.thesisTheme = thesisTheme;
        }

        public string? ThesisTheme
        {
            get
            {
                return thesisTheme;
            }
            set
            {
                thesisTheme = value;
            }
        }

        public void SetThesisTheme(string? thesisTheme)
        {
            this.thesisTheme = thesisTheme;
        }

        public string? GetThesisTheme()
        {
            return thesisTheme;
        }

        public void ToInternship()
        {
            Console.WriteLine(name + " starts an internship in " + speciality + ".");

        }

        public void DefendThesis()
        {
            Console.WriteLine(name + " defends his thesis on " + thesisTheme + ".");
        }

        public override string ToString()
        {
            string? strings = "\tAspirant Info: \n\n";
            strings += "Speciality: \t" + speciality + "\n";
            strings += "Thesis theme: \t" + thesisTheme + "\n";
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

        public override void Study()
        {
            Console.WriteLine("Aspirant " + name + " " + LastName + " studyes programming in C# language\n");
        }

        public override void TakeExam()
        {
            Console.WriteLine("Aspirant " + name + " " + LastName + " passed the exams with " + exams.Average() + " points\n");
        }

        public static bool operator <(Aspirant left, Aspirant right)
        {
            return left.AverageRatings() < right.AverageRatings();
        }

        public static bool operator >(Aspirant left, Aspirant right)
        {
            return !(left < right);
        }

        public static bool operator true(Aspirant aspirant)
        {
            return aspirant.AverageRatings() >= 10;
        }

        public static bool operator false(Aspirant aspirant)
        {
            return aspirant.AverageRatings() < 10;
        }

        public static bool operator ==(Aspirant left, Aspirant right)
        {
            return left.AverageRatings() == right.AverageRatings();
        }

        public static bool operator !=(Aspirant left, Aspirant right)
        {
            return !(left == right);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Aspirant aspirant)
            {
                return this == aspirant;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return AverageRatings().GetHashCode();
        }
    }
}

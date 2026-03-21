using dpiotrowski_lab1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dpiotrowski_lab1.Presenters
{
    internal static class StudentValidator
    {
        static public Student FromStudentData(StudentData studentData)
        {
            if (studentData.Name.Length == 0)
            {
                throw new ArgumentException("Imię studenta nie może być puste");
            }

            if (studentData.LastName.Length == 0)
            {
                throw new ArgumentException("Nazwisko studenta nie może być puste");
            }

            if (studentData.DateOfBirth > DateTime.Now)
            {
                throw new ArgumentException("Data urodzenia studenta musi być w przeszłości");
            }

            YearOfStudy yearOfStudy;

            switch (studentData.YearOfStudy)
            {
                case "I":
                    yearOfStudy = YearOfStudy.I;
                    break;

                case "II":
                    yearOfStudy = YearOfStudy.II;
                    break;

                case "III":
                    yearOfStudy = YearOfStudy.III;
                    break;

                default:
                    throw new ArgumentException("Nie wybrano poprawnego roku studiów! " + studentData.YearOfStudy);
            }

            if (studentData.City.Length == 0)
            {
                throw new ArgumentException("Miasto nie może być puste");
            }

            if (!Regex.IsMatch(studentData.PostalCodeFirst, @"[0-9]{2}") ||
                !Regex.IsMatch(studentData.PostalCodeSecond, @"[0-9]{3}"))
            {
                throw new ArgumentException("Kod pocztowy został wypełniony niepoprawnie");
            }

            if (studentData.Street.Length == 0)
            {
                throw new ArgumentException("Nazwa ulicy nie może być pusta");
            }

            if (!Regex.IsMatch(studentData.BuildingNumber, @"[0-9][0-9A-Z]*"))
            {
                throw new ArgumentException("Wprowadzono niepoprawny numer budynku");
            }

            uint? flatNumber;

            try
            {
                if (studentData.FlatNumber != null)
                {
                    flatNumber = UInt32.Parse(studentData.FlatNumber);
                } else
                {
                    flatNumber = null;
                }
            }
            catch (FormatException)
            {
                throw new ArgumentException("Wprowadzono niepoprawny numer mieszkania");
            }

            return new Student(
                studentData.Name,
                studentData.LastName,
                studentData.DateOfBirth,
                new Address(
                    studentData.City,
                    new PostalCode(
                        UInt32.Parse(studentData.PostalCodeFirst),
                        UInt32.Parse(studentData.PostalCodeSecond)),
                    studentData.Street,
                    studentData.BuildingNumber,
                    flatNumber),
                yearOfStudy);
        }

        static public IDStudentData FromStudent(Student student)
        {
            string yearOfStudy = "";

            switch(student.YearOfStudy)
            {
                case YearOfStudy.I:
                    yearOfStudy = "I";
                    break;

                case YearOfStudy.II:
                    yearOfStudy = "II";
                    break;

                case YearOfStudy.III:
                    yearOfStudy = "III";
                    break;
            }

            string flatNumber = "";

            if(student.Address.FlatNumber.HasValue)
            {
                flatNumber = student.Address.FlatNumber.Value.ToString();
            }

            return new IDStudentData(
                student.Id,
                student.Name,
                student.LastName,
                student.DateOfBirth,
                yearOfStudy,
                student.Address.City,
                student.Address.PostalCode.First.ToString(),
                student.Address.PostalCode.Second.ToString(),
                student.Address.Street,
                student.Address.BuildingNumber,
                flatNumber);
        }
    }
}

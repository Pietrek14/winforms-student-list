using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab1.Presenters
{
    public class StudentData
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string YearOfStudy { get; set; }
        public string City { get; set; }
        public string PostalCodeFirst { get; set; }
        public string PostalCodeSecond { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public string? FlatNumber { get; set; }

        public StudentData(string name, string lastName, DateTime dateOfBirth, string yearOfStudy, string city, string postalCodeFirst, string postalCodeSecond, string street, string building, string? flat)
        {
            Name = name;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            YearOfStudy = yearOfStudy;
            City = city;
            PostalCodeFirst = postalCodeFirst;
            PostalCodeSecond = postalCodeSecond;
            Street = street;
            BuildingNumber = building;
            FlatNumber = flat;
        }

        override public String ToString()
        {
            return $"{this.Name} {this.LastName}";
        }
    }

    public class IDStudentData : StudentData
    {
        public Guid Id { get; set; }

        public IDStudentData(Guid id, string name, string lastName, DateTime dateOfBirth, string yearOfStudy, string city, string postalCodeFirst, string postalCodeSecond, string street, string building, string? flat) : base(name, lastName, dateOfBirth, yearOfStudy, city, postalCodeFirst, postalCodeSecond, street, building, flat)
        {
            Id = id;
        }

        override public String ToString()
        {
            return $"{this.Name} {this.LastName} (ID: {this.Id})";
        }
    }
}

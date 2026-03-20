using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace dpiotrowski_lab1.Models
{
    public enum YearOfStudy
    {
        I,
        II,
        III
    }

    public class Student
    {
        private Guid _id;
        [JsonInclude]
        public Guid Id {
            get { return _id; }
            private set { _id = value; }
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        private DateTime _dateOfBirth;
        [JsonInclude]
        public DateTime DateOfBirth {
            get { return _dateOfBirth; }
            private set { _dateOfBirth = value; }
        }
        public Address Address { get; set; }
        public YearOfStudy YearOfStudy { get; set; }

        public Student(string name, string lastName, DateTime dateOfBirth, Address address, YearOfStudy yearOfStudy)
        {
            this._id = Guid.NewGuid();
            this.Name = name;
            this.LastName = lastName;
            this._dateOfBirth = dateOfBirth;
            this.Address = address;
            this.YearOfStudy = yearOfStudy;
        }
    }
}

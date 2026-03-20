using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab1.Models
{
    public class PostalCode
    {
        public uint First { get; set; }
        public uint Second { get; set; }

        public PostalCode(uint first, uint second)
        {
            this.First = first;
            this.Second = second;
        }

        public override string ToString()
        {
            return this.First.ToString() + " - " + this.Second.ToString();
        }
    }

    public class Address
    {
        public string City { get; set; }
        public PostalCode PostalCode { get; set; }
        public string Street { get; set; }
        public uint BuildingNumber { get; set; }
        public uint? FlatNumber { get; set; }

        public Address(string city, PostalCode postalCode, string street, uint buildingNumber, uint? flatNumber)
        {
            this.City = city;
            this.PostalCode = postalCode;
            this.Street = street;
            this.BuildingNumber = buildingNumber;
            this.FlatNumber = flatNumber;
        }
    }
}

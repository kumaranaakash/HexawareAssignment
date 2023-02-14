using System;

namespace RelationShipAssignment
{
    internal class Program
    {
        class Address
        {
            public string street, city, state, zipCode;
            public Address(string street, string city, string state, string zipCode)
            {
                this.street = street;
                this.city = city;
                this.state = state;
                this.zipCode = zipCode;
            }


        }
        class Employee
        {
            public string name;
            public int empid;
            public Address address;
            public Employee(string name, int empid, Address address)
            {
                this.name = name;
                this.empid = empid;
                this.address = address;

            }

            public void GetEmpInfo()
            {
                Console.WriteLine($"emp id = {empid} \n name = {name} \n "+
                    $"street = {address.street}\n  city = { address.city}\n state = {address.state} \n"+
                    $"zipcode = {address.zipCode}");
            }
            static void Main(string[] args)
            {
                Address address = new Address("VOC Street", "LakshmiNagar", "Erode", "638316");
                Employee employee = new Employee("Aakash", 1001, address);
                employee.GetEmpInfo();
            }
        }
    }
}

using System;
namespace Cource.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public String FirstName { get; set; } = String.Empty;
        public String LastName { get; set; } = String.Empty;
        public Address Address { get; set; } 
        public DateTime DOB { get; set; }
        public Boolean Status { get; set; }
    }

  
}


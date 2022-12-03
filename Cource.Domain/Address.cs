using System;
namespace Cource.Domain
{
    public class Address
    {
        public int Id { get; set; }
        public String AddressLine1 { get; set; } = String.Empty;
        public String AddressLine2 { get; set; } = String.Empty;
        public String City { get; set; } = String.Empty;
        public String PostalCode { get; set; } = String.Empty;

    }
}


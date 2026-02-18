namespace EcommerceDev.Core.Entities
{
    public class CustomerAddress : BaseEntity
    {
        public CustomerAddress(Guid idCustomer, string recipientName, string addressLine1, string? addressLine2, int zipCode, string district, string city, string state, string country)
        {
            IdCustomer = idCustomer;
            RecipientName = recipientName;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            ZipCode = zipCode;
            District = district;
            City = city;
            State = state;
            Country = country;
        }

        public Guid IdCustomer { get; set; }
        public string RecipientName { get; set; }
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public int ZipCode { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
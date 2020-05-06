using BasicApi.Enums;

namespace BasicApi.Models
{
    public class Customer : EntityBase
    {
        public string Name { get; set; }

        public string DocumentNumber { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }
    }
}
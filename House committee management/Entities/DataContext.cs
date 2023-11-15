using house_committee.Entities;

namespace house_committee
{
    public class DataContext
    {
        public List<Month> months { get; set; }
        public List<Tenant> tenantList { get; set; }
        public List<Payment> paymentList { get; set; }

        public DataContext()
        {
            months = new List<Month>()
            {
                new Month(){Name=EmonthName.January,IsTake=false},
                new Month(){Name=EmonthName.February,IsTake=false},
                new Month(){Name=EmonthName.March, IsTake = false},
                new Month(){Name=EmonthName.April,IsTake = false},
                new Month(){Name=EmonthName.May, IsTake = false},
                new Month(){Name=EmonthName.June, IsTake = false},
                new Month(){Name=EmonthName.July, IsTake = false},
                new Month(){Name=EmonthName.August, IsTake = false},
                new Month(){Name=EmonthName.September, IsTake = false},
                new Month(){Name=EmonthName.October, IsTake = false},
                new Month(){Name=EmonthName.November, IsTake = false},
                new Month(){Name=EmonthName.December, IsTake = false}
            };
            tenantList = new List<Tenant>()
{
    new Tenant
    {
        Name = "berkovitz",
        floor = 3,
        Phone = "0523689415",
        type = EtypeTenant.apartment,
        IsPaid = Enumerable.Repeat(false, 12).ToList() // Initialize with 12 elements, all set to false
    },
    new Tenant
    {
        Name = "shvartzman",
        floor = 1,
        Phone = "0587456516",
        type = EtypeTenant.apartment,
        IsPaid = Enumerable.Repeat(false, 12).ToList()
    },
    new Tenant
    {
        Name = "avrahmskey",
        floor = 1,
        Phone = "8198784657",
        type = EtypeTenant.unit,
        IsPaid = Enumerable.Repeat(false, 12).ToList()
    }
};
            paymentList = new List<Payment>()
            {
                new Payment() { eMethods = EMethods.credit, epurpose = Epurpose.electrical, Sum = 250, IsPayd = false },
                new Payment() { epurpose = Epurpose.cleaner, eMethods = EMethods.cash, Sum = 300, IsPayd = false },
            };
        }
    }
}

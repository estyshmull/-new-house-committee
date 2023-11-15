namespace house_committee.Entities
{
    public enum EtypeTenant { unit, apartment };
    public class Tenant
    {
        static int id = 0;
        public string Name { get; set; }
        public int Id { get; }
        public string Phone { get; set; }
        public int floor { get; set; }
        public List<bool> IsPaid { get; set; }
        public EtypeTenant type { get; set; }

        public Tenant()
        {
            Id = id++;
        }
        public Tenant(string name, int id, string phone, int floor, EtypeTenant type)
        {
            Name = name;
            Id = id;
            Phone = phone;
            this.floor = floor;
            this.type = type;
        }
    }
}

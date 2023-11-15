namespace house_committee.Entities
{
    public enum Epurpose { cleaner, water, electrical };
    public enum EMethods { tshsik, cash, credit };
    public class Payment
    {
        static int id = 0;
        public int Id { get; }
        public Epurpose epurpose { get; set; }
        public EMethods eMethods { get; set; }
        public int Sum { get; set; }
        public bool IsPayd { get; set; }

        public Payment(Epurpose myProperty, EMethods eMethods, bool ispay, int sum)
        {
            Id = id++;
            epurpose = myProperty;
            this.eMethods = eMethods;
            Sum = sum;
            IsPayd = ispay;
        }
        public Payment()
        {
            Id = id++;
        }
    }
}

using System;

namespace BridgeDemoP
{
    public abstract class GymTicket 
    {
        private readonly Discount _discount;

        protected GymTicket(string name, DateTime purchaseTime, Discount discount)
        {
            Name = name;
            PurchaseTime = purchaseTime;
            _discount = discount;
        }
        public string Name { get; set; }
        protected abstract double Price { get;}
        public DateTime PurchaseTime { get; set; }
        public abstract DateTime GetExpirationDate();
        public double GetPrice() => Price * _discount.GetDiscount();
    }


    public class OneTimeGymTicket: GymTicket
    {
        public OneTimeGymTicket(string name, DateTime purchaseTime, Discount discount) : base(name, purchaseTime, discount)
        {
        }
        protected override double Price => 1500;

        public override DateTime GetExpirationDate()
        {
            return PurchaseTime.AddHours(3);
        }

    }

    public class MonthlyGymTicket : GymTicket
    {
        public MonthlyGymTicket(string name, DateTime purchaseTime, Discount discount) : base(name, purchaseTime, discount)
        {
        }
        protected override double Price => 15000;

        public override DateTime GetExpirationDate()
        {
            return PurchaseTime.AddDays(30);
        }
    }
    public class ThreeMonthGymTicket : GymTicket
    {
        public ThreeMonthGymTicket(string name, DateTime purchaseTime, Discount discount) : base(name, purchaseTime, discount)
        {
        }
        protected override double Price => 30000;

        public override DateTime GetExpirationDate()
        {
            return PurchaseTime.AddDays(90);
        }
    }
}

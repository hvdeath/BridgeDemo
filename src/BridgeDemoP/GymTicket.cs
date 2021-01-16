using System;

namespace BridgeDemoP
{
    public abstract class GymTicket 
    {
        protected GymTicket(DateTime purchaseTime)
        {
            PurchaseTime = purchaseTime;
        }
        public abstract string Name { get;  }
        public abstract double Price { get;}
        public DateTime PurchaseTime { get; set; }
        
        public abstract DateTime GetExpirationDate();
    }


    public class OneTimeGymTicket: GymTicket
    {
        public OneTimeGymTicket(DateTime purchaseTime): base(purchaseTime)
        {
        }
        public override string Name => "Daily gym ticket";
        public override double Price => 1500;

        public override DateTime GetExpirationDate()
        {
            return PurchaseTime.AddHours(3);
        }
    }

    public class MonthlyGymTicket : GymTicket
    {
        public MonthlyGymTicket(DateTime purchaseTime) : base(purchaseTime)
        {
        }
        public override string Name => "Monthly ticket";
        public override double Price => 15000;

        public override DateTime GetExpirationDate()
        {
            return PurchaseTime.AddDays(30);
        }
    }
}

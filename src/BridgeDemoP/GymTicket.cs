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
        protected abstract double Price { get;}
        public DateTime PurchaseTime { get; set; }
        public abstract DateTime GetExpirationDate();
        public abstract double GetPrice();
    }


    public class OneTimeGymTicket: GymTicket
    {
        public OneTimeGymTicket(DateTime purchaseTime): base(purchaseTime)
        {
        }
        public override string Name => "One Time gym ticket";
        protected override double Price => 1500;

        public override DateTime GetExpirationDate()
        {
            return PurchaseTime.AddHours(3);
        }

        public override double GetPrice() => Price;
    }

    public class MonthlyGymTicket : GymTicket
    {
        public MonthlyGymTicket(DateTime purchaseTime) : base(purchaseTime)
        {
        }
        public override string Name => "Monthly ticket";
        protected override double Price => 15000;

        public override DateTime GetExpirationDate()
        {
            return PurchaseTime.AddDays(30);
        }
        public override double GetPrice() => Price;
    }
    public class ThreeMonthGymTicket : GymTicket
    {
        public ThreeMonthGymTicket(DateTime purchaseTime) : base(purchaseTime)
        {
        }
        public override string Name => "Three Month ticket";
        protected override double Price => 30000;

        public override DateTime GetExpirationDate()
        {
            return PurchaseTime.AddDays(90);
        }
        public override double GetPrice() => Price;
    }

    public class StudentOneTimeGymTicket : OneTimeGymTicket
    {
        public StudentOneTimeGymTicket(DateTime purchaseTime) : base(purchaseTime)
        {
        }
        public override string Name => "Student one timeym ticket";

       
        public override double GetPrice() => Price*0.8;
    }

    public class StudentMonthlyGymTicket : MonthlyGymTicket
    {
        public StudentMonthlyGymTicket(DateTime purchaseTime) : base(purchaseTime)
        {
        }
        public override string Name => "Monthly ticket";

        public override double GetPrice() => Price * 0.8;
    }

    public class StudentThreeMonthGymTicket : ThreeMonthGymTicket
    {
        public StudentThreeMonthGymTicket(DateTime purchaseTime) : base(purchaseTime)
        {
        }
        public override string Name => "Three Month ticket";

        public override double GetPrice() => Price * 0.8;
    }

    public class SeniorOneTimeGymTicket : OneTimeGymTicket
    {
        public SeniorOneTimeGymTicket(DateTime purchaseTime) : base(purchaseTime)
        {
        }
        public override string Name => "Senior one timeym ticket";


        public override double GetPrice() => Price * 0.5;
    }

    public class SeniorMonthlyGymTicket : MonthlyGymTicket
    {
        public SeniorMonthlyGymTicket(DateTime purchaseTime) : base(purchaseTime)
        {
        }
        public override string Name => "Monthly ticket";

        public override double GetPrice() => Price * 0.5;

    }

    public class SeniorThreeMonthGymTicket : ThreeMonthGymTicket
    {
        public SeniorThreeMonthGymTicket(DateTime purchaseTime) : base(purchaseTime)
        {
        }
        public override string Name => "Three Month ticket";

        public override double GetPrice() => Price * 0.5;
    }
}

using System;

namespace BridgeDemoP
{
    public abstract class GymTicket 
    {
        protected GymTicket(string name, DateTime purchaseTime)
        {
            Name = name;
            PurchaseTime = purchaseTime;
        }
        public string Name { get; set; }
        protected abstract double Price { get;}
        public DateTime PurchaseTime { get; set; }
        public abstract DateTime GetExpirationDate();
        public abstract double GetPrice();
    }


    public class OneTimeGymTicket: GymTicket
    {
        public OneTimeGymTicket(string name, DateTime purchaseTime): base(name, purchaseTime)
        {
        }
        protected override double Price => 1500;

        public override DateTime GetExpirationDate()
        {
            return PurchaseTime.AddHours(3);
        }

        public override double GetPrice() => Price;
    }

    public class MonthlyGymTicket : GymTicket
    {
        public MonthlyGymTicket(string name, DateTime purchaseTime): base(name, purchaseTime)
        {
        }
        protected override double Price => 15000;

        public override DateTime GetExpirationDate()
        {
            return PurchaseTime.AddDays(30);
        }
        public override double GetPrice() => Price;
    }
    public class ThreeMonthGymTicket : GymTicket
    {
        public ThreeMonthGymTicket(string name, DateTime purchaseTime): base(name, purchaseTime)
        {
        }
        protected override double Price => 30000;

        public override DateTime GetExpirationDate()
        {
            return PurchaseTime.AddDays(90);
        }
        public override double GetPrice() => Price;
    }

    public class StudentOneTimeGymTicket : OneTimeGymTicket
    {
        public StudentOneTimeGymTicket(string name, DateTime purchaseTime): base(name, purchaseTime)
        {
        }
       
        public override double GetPrice() => Price*0.8;
    }

    public class StudentMonthlyGymTicket : MonthlyGymTicket
    {
        public StudentMonthlyGymTicket(string name, DateTime purchaseTime): base(name, purchaseTime)
        {
        }

        public override double GetPrice() => Price * 0.8;
    }

    public class StudentThreeMonthGymTicket : ThreeMonthGymTicket
    {
        public StudentThreeMonthGymTicket(string name, DateTime purchaseTime): base(name, purchaseTime)
        {
        }

        public override double GetPrice() => Price * 0.8;
    }

    public class SeniorOneTimeGymTicket : OneTimeGymTicket
    {
        public SeniorOneTimeGymTicket(string name, DateTime purchaseTime): base(name, purchaseTime)
        {
        }

        public override double GetPrice() => Price * 0.5;
    }

    public class SeniorMonthlyGymTicket : MonthlyGymTicket
    {
        public SeniorMonthlyGymTicket(string name, DateTime purchaseTime): base(name, purchaseTime)
        {
        }

        public override double GetPrice() => Price * 0.5;

    }

    public class SeniorThreeMonthGymTicket : ThreeMonthGymTicket
    {
        public SeniorThreeMonthGymTicket(string name, DateTime purchaseTime): base(name, purchaseTime)
        {
        }

        public override double GetPrice() => Price * 0.5;
    }
}

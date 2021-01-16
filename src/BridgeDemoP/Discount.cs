namespace BridgeDemoP
{
    public abstract class Discount
    {
        public abstract double GetDiscount();
    }

    public class NoDiscount : Discount
    {
        public override double GetDiscount() => 1;
    }

    public class StudentDiscount : Discount
    {
        public override double GetDiscount() => 0.8;
    }

    public class SeniorDiscount : Discount
    {
        public override double GetDiscount() => 0.5;
    }

    public class AfterCovidDiscount : Discount
    {
        public override double GetDiscount() => 0.4;
    }
}

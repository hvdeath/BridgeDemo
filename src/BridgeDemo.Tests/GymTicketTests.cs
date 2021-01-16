using BridgeDemoP;
using NFluent;
using System;
using Xunit;

namespace BridgeDemo.Tests
{
    public class GymTicketTests
    {
        [Fact]
        public void Should_OneTimeTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new OneTimeGymTicket(nameof(OneTimeGymTicket), DateTime.Now, new NoDiscount());

            //ASSERT
            Check.That(result.GetPrice()).IsEqualTo(1500);
        }

        [Fact]
        public void Should_MonthlyTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new MonthlyGymTicket(nameof(MonthlyGymTicket),DateTime.Now, new NoDiscount());

            //ASSERT
            Check.That(result.GetPrice()).IsEqualTo(15000);
        }

        [Fact]
        public void Should_ThreeMonthGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new ThreeMonthGymTicket(nameof(ThreeMonthGymTicket),DateTime.Now, new NoDiscount());

            //ASSERT
            Check.That(result.GetPrice()).IsEqualTo(30000);
        }

        [Fact]
        public void Should_StudentOneTimeGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new OneTimeGymTicket(nameof(OneTimeGymTicket), DateTime.Now, new StudentDiscount());

            //ASSERT
            GymTicket refTicket = new OneTimeGymTicket(nameof(OneTimeGymTicket),DateTime.Now, new NoDiscount());

            Check.That(result.GetPrice()).IsEqualTo(refTicket.GetPrice() * 0.8);
        }

        [Fact]
        public void Should_StudentMonthlyGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new MonthlyGymTicket(nameof(MonthlyGymTicket), DateTime.Now, new StudentDiscount());


            //ASSERT
            GymTicket refTicket = new MonthlyGymTicket(nameof(MonthlyGymTicket), DateTime.Now, new NoDiscount());

            Check.That(result.GetPrice()).IsEqualTo(refTicket.GetPrice() * 0.8);
        }

        [Fact]
        public void Should_StudentThreeMonthGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new ThreeMonthGymTicket(nameof(ThreeMonthGymTicket), DateTime.Now, new StudentDiscount());

            //ASSERT
            GymTicket refTicket = new ThreeMonthGymTicket(nameof(ThreeMonthGymTicket), DateTime.Now, new NoDiscount());

            Check.That(result.GetPrice()).IsEqualTo(refTicket.GetPrice() * 0.8);
        }

        [Fact]
        public void Should_SeniorOneTimeGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new OneTimeGymTicket(nameof(OneTimeGymTicket), DateTime.Now, new SeniorDiscount());

            //ASSERT
            GymTicket refTicket = new OneTimeGymTicket(nameof(OneTimeGymTicket), DateTime.Now, new NoDiscount());

            Check.That(result.GetPrice()).IsEqualTo(refTicket.GetPrice() * 0.5);
        }

        [Fact]
        public void Should_SeniorMonthlyGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new MonthlyGymTicket(nameof(MonthlyGymTicket), DateTime.Now, new SeniorDiscount());

            //ASSERT
            GymTicket refTicket = new MonthlyGymTicket(nameof(MonthlyGymTicket), DateTime.Now, new NoDiscount());

            Check.That(result.GetPrice()).IsEqualTo(refTicket.GetPrice() * 0.5);
        }

        [Fact]
        public void Should_SeniorThreeMonthGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new ThreeMonthGymTicket(nameof(ThreeMonthGymTicket), DateTime.Now, new SeniorDiscount());

            //ASSERT
            GymTicket refTicket = new ThreeMonthGymTicket(nameof(ThreeMonthGymTicket), DateTime.Now, new NoDiscount());

            Check.That(result.GetPrice()).IsEqualTo(refTicket.GetPrice() * 0.5);
        }
    }
}

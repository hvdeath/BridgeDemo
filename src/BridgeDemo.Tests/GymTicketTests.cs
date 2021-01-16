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
            GymTicket result = new OneTimeGymTicket(nameof(OneTimeGymTicket), DateTime.Now);

            //ASSERT
            Check.That(result.Name).IsEqualTo(nameof(OneTimeGymTicket));
            Check.That(result.GetPrice()).IsEqualTo(1500);
        }

        [Fact]
        public void Should_MonthlyTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new MonthlyGymTicket(nameof(MonthlyGymTicket),DateTime.Now);

            //ASSERT
            Check.That(result.Name).IsEqualTo(nameof(MonthlyGymTicket));
            Check.That(result.GetPrice()).IsEqualTo(15000);
        }

        [Fact]
        public void Should_ThreeMonthGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new ThreeMonthGymTicket(nameof(ThreeMonthGymTicket),DateTime.Now);

            //ASSERT
            Check.That(result.Name).IsEqualTo(nameof(ThreeMonthGymTicket));
            Check.That(result.GetPrice()).IsEqualTo(30000);
        }

        [Fact]
        public void Should_StudentOneTimeGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new StudentOneTimeGymTicket(nameof(StudentOneTimeGymTicket), DateTime.Now);

            //ASSERT
            GymTicket refTicket = new OneTimeGymTicket(nameof(OneTimeGymTicket),DateTime.Now);

            Check.That(result.Name).IsEqualTo(nameof(StudentOneTimeGymTicket));
            Check.That(result.GetPrice()).IsEqualTo(refTicket.GetPrice() * 0.8);
        }

        [Fact]
        public void Should_StudentMonthlyGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new StudentMonthlyGymTicket(nameof(ThreeMonthGymTicket), DateTime.Now);

            //ASSERT
            GymTicket refTicket = new MonthlyGymTicket(nameof(MonthlyGymTicket), DateTime.Now);

            Check.That(result.Name).IsEqualTo(nameof(ThreeMonthGymTicket));
            Check.That(result.GetPrice()).IsEqualTo(refTicket.GetPrice() * 0.8);
        }

        [Fact]
        public void Should_StudentThreeMonthGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new StudentThreeMonthGymTicket(nameof(StudentThreeMonthGymTicket), DateTime.Now);

            //ASSERT
            GymTicket refTicket = new ThreeMonthGymTicket(nameof(ThreeMonthGymTicket), DateTime.Now);

            Check.That(result.Name).IsEqualTo(nameof(StudentThreeMonthGymTicket));
            Check.That(result.GetPrice()).IsEqualTo(refTicket.GetPrice() * 0.8);
        }

        [Fact]
        public void Should_SeniorOneTimeGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new SeniorOneTimeGymTicket(nameof(SeniorOneTimeGymTicket), DateTime.Now);

            //ASSERT
            GymTicket refTicket = new OneTimeGymTicket(nameof(OneTimeGymTicket), DateTime.Now);

            Check.That(result.Name).IsEqualTo(nameof(SeniorOneTimeGymTicket));
            Check.That(result.GetPrice()).IsEqualTo(refTicket.GetPrice() * 0.5);
        }

        [Fact]
        public void Should_SeniorMonthlyGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new SeniorMonthlyGymTicket(nameof(SeniorMonthlyGymTicket), DateTime.Now);

            //ASSERT
            GymTicket refTicket = new MonthlyGymTicket(nameof(MonthlyGymTicket), DateTime.Now);

            Check.That(result.Name).IsEqualTo(nameof(MonthlyGymTicket));
            Check.That(result.GetPrice()).IsEqualTo(refTicket.GetPrice() * 0.5);
        }

        [Fact]
        public void Should_SeniorThreeMonthGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new SeniorThreeMonthGymTicket(nameof(SeniorThreeMonthGymTicket), DateTime.Now);

            //ASSERT
            GymTicket refTicket = new ThreeMonthGymTicket(nameof(ThreeMonthGymTicket), DateTime.Now);

            Check.That(result.Name).IsEqualTo(nameof(SeniorThreeMonthGymTicket));
            Check.That(result.GetPrice()).IsEqualTo(refTicket.GetPrice() * 0.5);
        }
    }
}

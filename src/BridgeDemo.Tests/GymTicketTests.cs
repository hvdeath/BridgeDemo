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
            GymTicket result = new OneTimeGymTicket(DateTime.Now);

            //ASSERT
            Check.That(result.Name).IsEqualTo("One Time gym ticket");
            Check.That(result.GetPrice()).IsEqualTo(1500);
        }

        [Fact]
        public void Should_MonthlyTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new MonthlyGymTicket(DateTime.Now);

            //ASSERT
            Check.That(result.Name).IsEqualTo("Monthly ticket");
            Check.That(result.GetPrice()).IsEqualTo(15000);
        }

        [Fact]
        public void Should_ThreeMonthGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new ThreeMonthGymTicket(DateTime.Now);

            //ASSERT
            Check.That(result.Name).IsEqualTo("Three Month ticket");
            Check.That(result.GetPrice()).IsEqualTo(30000);
        }

        [Fact]
        public void Should_StudentOneTimeGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new StudentOneTimeGymTicket(DateTime.Now);

            //ASSERT
            GymTicket refTicket = new OneTimeGymTicket(DateTime.Now);

            Check.That(result.Name).IsEqualTo("Student one timeym ticket");
            Check.That(result.GetPrice()).IsEqualTo(refTicket.GetPrice() * 0.8);
        }

        [Fact]
        public void Should_StudentMonthlyGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new StudentMonthlyGymTicket(DateTime.Now);

            //ASSERT
            GymTicket refTicket = new MonthlyGymTicket(DateTime.Now);

            Check.That(result.Name).IsEqualTo("Monthly ticket");
            Check.That(result.GetPrice()).IsEqualTo(refTicket.GetPrice() * 0.8);
        }

        [Fact]
        public void Should_StudentThreeMonthGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new StudentThreeMonthGymTicket(DateTime.Now);

            //ASSERT
            GymTicket refTicket = new ThreeMonthGymTicket(DateTime.Now);

            Check.That(result.Name).IsEqualTo("Three Month ticket");
            Check.That(result.GetPrice()).IsEqualTo(refTicket.GetPrice() * 0.8);
        }

        [Fact]
        public void Should_SeniorOneTimeGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new SeniorOneTimeGymTicket(DateTime.Now);

            //ASSERT
            GymTicket refTicket = new OneTimeGymTicket(DateTime.Now);

            Check.That(result.Name).IsEqualTo("Senior one timeym ticket");
            Check.That(result.GetPrice()).IsEqualTo(refTicket.GetPrice() * 0.5);
        }

        [Fact]
        public void Should_SeniorMonthlyGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new SeniorMonthlyGymTicket(DateTime.Now);

            //ASSERT
            GymTicket refTicket = new MonthlyGymTicket(DateTime.Now);

            Check.That(result.Name).IsEqualTo("Monthly ticket");
            Check.That(result.GetPrice()).IsEqualTo(refTicket.GetPrice() * 0.5);
        }

        [Fact]
        public void Should_SeniorThreeMonthGymTicket_HasCorrectData()
        {
            // ARRANGE

            //ACT
            GymTicket result = new SeniorThreeMonthGymTicket(DateTime.Now);

            //ASSERT
            GymTicket refTicket = new ThreeMonthGymTicket(DateTime.Now);

            Check.That(result.Name).IsEqualTo("Three Month ticket");
            Check.That(result.GetPrice()).IsEqualTo(refTicket.GetPrice() * 0.5);
        }
    }
}

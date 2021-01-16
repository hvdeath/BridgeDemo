using BridgeDemoP;
using System;


Console.WriteLine("Hello World Bridge Demo!");


PrintDetails(new OneTimeGymTicket(nameof(OneTimeGymTicket), DateTime.Now, new NoDiscount()));
PrintDetails(new MonthlyGymTicket(nameof(MonthlyGymTicket), DateTime.Now, new NoDiscount()));
PrintDetails(new ThreeMonthGymTicket(nameof(ThreeMonthGymTicket), DateTime.Now, new NoDiscount()));

PrintDetails(new OneTimeGymTicket($"Student {nameof(OneTimeGymTicket)}", DateTime.Now, new StudentDiscount()));
PrintDetails(new MonthlyGymTicket($"Student nameof(MonthlyGymTicket)", DateTime.Now, new StudentDiscount()));
PrintDetails(new ThreeMonthGymTicket($"Student nameof(ThreeMonthGymTicket)", DateTime.Now, new StudentDiscount()));

PrintDetails(new OneTimeGymTicket($"Senior nameof(OneTimeGymTicket)", DateTime.Now, new SeniorDiscount()));
PrintDetails(new MonthlyGymTicket($"Senior nameof(MonthlyGymTicket)", DateTime.Now, new SeniorDiscount()));
PrintDetails(new ThreeMonthGymTicket($"Senior nameof(ThreeMonthGymTicket)", DateTime.Now, new SeniorDiscount()));

PrintDetails(new OneTimeGymTicket($"AfterCovidDiscount {nameof(OneTimeGymTicket)}", DateTime.Now, new AfterCovidDiscount()));
PrintDetails(new MonthlyGymTicket($"AfterCovidDiscount nameof(MonthlyGymTicket)", DateTime.Now, new AfterCovidDiscount()));
PrintDetails(new ThreeMonthGymTicket($"AfterCovidDiscount nameof(ThreeMonthGymTicket)", DateTime.Now, new AfterCovidDiscount()));


static void PrintDetails(GymTicket ticket)
{
    Console.WriteLine($"Gym: {ticket.Name}");
    Console.WriteLine($"Price: {GetPrice(ticket)}");
    Console.WriteLine($"Valid for: {GetValidFor(ticket)}");

    Console.WriteLine();
}

static string GetPrice(GymTicket ticket)
{
    return $"{ticket.GetPrice():0.00} HUF";
}

static string GetValidFor(GymTicket ticket)
{
    DateTime? expirationDate = ticket.GetExpirationDate();

    if (expirationDate == null)
        return "Forever";

    TimeSpan timeSpan = expirationDate.Value - DateTime.Now;

    return $"{timeSpan.Days}d {timeSpan.Hours}h {timeSpan.Minutes}m";
}
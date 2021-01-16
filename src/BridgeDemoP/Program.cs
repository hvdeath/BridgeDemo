using BridgeDemoP;
using System;


Console.WriteLine("Hello World Bridge Demo!");


PrintDetails(new OneTimeGymTicket(DateTime.Now));
PrintDetails(new MonthlyGymTicket(DateTime.Now));


static void PrintDetails(GymTicket ticket)
{
    Console.WriteLine($"Gym: {ticket.Name}");
    Console.WriteLine($"Price: {GetPrice(ticket)}");
    Console.WriteLine($"Valid for: {GetValidFor(ticket)}");

    Console.WriteLine();
}

static string GetPrice(GymTicket ticket)
{
    return $"{ticket.Price:0.00} HUF";
}

static string GetValidFor(GymTicket ticket)
{
    DateTime? expirationDate = ticket.GetExpirationDate();

    if (expirationDate == null)
        return "Forever";

    TimeSpan timeSpan = expirationDate.Value - DateTime.Now;

    return $"{timeSpan.Days}d {timeSpan.Hours}h {timeSpan.Minutes}m";
}
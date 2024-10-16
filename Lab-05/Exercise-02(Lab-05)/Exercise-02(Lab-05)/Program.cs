using System;

public class Customer
{
    public int CustomerId { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

public class CorporateCustomer : Customer
{
    public string CompanyName { get; set; }
    public int SeatingCapacity { get; set; }
}

public class RetailCustomer : Customer
{
    public string CreditCardType { get; set; }
    public int FrequentFlyerPts { get; set; }
    public string CreditCardNo { get; set; }
    public string BillingAccountNo { get; set; }
}

public class Flight
{
    public int FlightId { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
}

public class Reservation
{
    public int RowNo { get; set; }
    public int SeatNo { get; set; }
    public DateTime Date { get; set; }
    public Flight FlightDetails { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create a retail customer object
        RetailCustomer retailCustomer = new RetailCustomer
        {
            CustomerId = 1,
            LastName = "Talib",
            FirstName = "Bilal",
            CreditCardType = "Visa",
            FrequentFlyerPts = 150,
            CreditCardNo = "1234-5678-9876-5432",
            BillingAccountNo = "BA123456"
        };

        // Output customer information
        Console.WriteLine("Customer Information:");
        Console.WriteLine("---------------------");
        Console.WriteLine($"Customer ID: {retailCustomer.CustomerId}");
        Console.WriteLine($"Name: {retailCustomer.FirstName} {retailCustomer.LastName}");
        Console.WriteLine($"Credit Card Type: {retailCustomer.CreditCardType}");
        Console.WriteLine($"Frequent Flyer Points: {retailCustomer.FrequentFlyerPts}");
        Console.WriteLine($"Credit Card Number: {retailCustomer.CreditCardNo}");
        Console.WriteLine($"Billing Account Number: {retailCustomer.BillingAccountNo}");
    }
}

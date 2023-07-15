// Book.cs
using System;

public class Book
{
    public string Title { get; set; }
    public int NumberOfDays { get; set; }

    public DateTime GetCurrentDate()
    {
        Console.Write("Enter the current date (format: dd/MM/yyyy): ");
        if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime currentDate))
        {
            return currentDate;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter in the format: dd/MM/yyyy.");
            return DateTime.MinValue;
        }
    }

    public void PrintExpectedReturnDate()
    {
        DateTime currentDate = GetCurrentDate();
        DateTime expectedReturnDate = currentDate.AddDays(NumberOfDays);
        Console.WriteLine($"Expected return date for {Title}: {expectedReturnDate.ToString("dd/MM/yyyy")}");
        Console.WriteLine();
    }
}

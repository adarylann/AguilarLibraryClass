// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Daryl's Library!");

        BookLibrary bookLibrary = new BookLibrary();
        bookLibrary.DisplayBookList();

        Console.Write("Enter the number of books you need: ");
        int numberOfBooks;
        if (!int.TryParse(Console.ReadLine(), out numberOfBooks))
        {
            Console.WriteLine("Invalid input. Please enter a valid input.");
            return;
        }

        Console.WriteLine();

        for (int i = 1; i <= numberOfBooks; i++)
        {
            Console.WriteLine($"Book #{i}");

            Book book = new Book();
            book.Title = GetBookTitle();

            book.NumberOfDays = GetNumberOfDays();

            book.PrintExpectedReturnDate();
        }

        Console.WriteLine("Thank you for using the Daryl's Library!");
        Console.ReadKey();
    }

    static string GetBookTitle()
    {
        Console.Write("Enter the title of the book: ");
        return Console.ReadLine();
    }

    static int GetNumberOfDays()
    {
        Console.Write("Enter the number of days you need the book: ");
        if (int.TryParse(Console.ReadLine(), out int numberOfDays))
        {
            return numberOfDays;
        }
        else
        {
            Console.WriteLine("Invalid input.");
            return 0;
        }
    }
}

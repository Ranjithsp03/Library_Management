using System;
namespace library;
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Isbn { get; set; }

    public void displaydetails()
    {
        Console.WriteLine($"Title:{Title}");
        Console.WriteLine($"Author:{Author}");
        Console.WriteLine($"ISBN:{Isbn}");
    }
}

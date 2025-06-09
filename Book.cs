using System;
namespace library;
public class Book:Libraryitem
{
    
    public string Author { get; set; }
    public string Isbn { get; set; }
    public Book(string id,string title, string author, string isbn) : base (id,title)
    {
        Id = id;
        Title = title;
        Author = author;
        Isbn = isbn;
    }
    public Book() { }
    public void displaydetails()
    {
        Console.WriteLine($"Title:{Title}");
        Console.WriteLine($"Author:{Author}");
        Console.WriteLine($"Title:{Isbn}");
    }
}

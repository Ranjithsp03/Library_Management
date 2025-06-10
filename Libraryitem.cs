using System.Diagnostics.Contracts;
using library;
public class Libraryitem
{
    public string Id { get; set; }
    public string Title { get; set; }
    public Libraryitem(string id,string title)
    {
        Id = id;
        Title = title;
    }
    public Libraryitem() { }
    public void Showinfo()
    {
        Console.WriteLine($"The id is:\t{Id}");
        Console.WriteLine($"The Title is:\t {Title}");
    }

}


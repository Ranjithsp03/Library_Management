namespace library;

using System.Collections;
using System.Net.Http.Headers;

public class Library
{
    private List<Libraryitem> libraryItems;
    private List<Book> BookItems;
    private List<Magazine> Magazines;
    private HashSet<string> booktitle;
    NotificationService notificationService;
    public Library()
    {
        libraryItems = new List<Libraryitem>();
        BookItems = new List<Book>();
        Magazines = new List<Magazine>();
        notificationService = new NotificationService();
        notificationService.Onnotify += notificationService.SendemailNotification;

        booktitle = new HashSet<string>();
    }
    // public void AddItem(Libraryitem item)
    // {
    //     libraryItems.Add(item);
    // }

    public void AddBook(Book item)
    {
        if (booktitle.Contains(item.Title))
        {
            throw new BookAlreadyExistsException($"The book '{item.Title}'already exists");
        }
        BookItems.Add(item);
        booktitle.Add(item.Title);
        notificationService.Notify($"A new Book '{item.Title}' has been added");
    }
    // public void AddItem(Magazine item)
    // {
    //     Magazines.Add(item);
    // }


    public void RemoveItem(Libraryitem item)
    {
        Console.WriteLine("The removed item is:");
        item.Showinfo();
        libraryItems.Remove(item);

    }
    public void RemoveBook(Book item)
    {
        // Console.WriteLine("The removed item is:");
        // item.Showinfo();
        BookItems.Remove(item);
        notificationService.Notify($"A  Book  has been Taken by user:'{item.Title}'");    

    }
    public void IssuseBook(string item,string user)
    {
           
    }
    public void RemoveItem(Magazine item)
    {
        Console.WriteLine("The removed item is:");
        item.Showinfo();
        Magazines.Remove(item);

    }
    public void ListItems()
    {
        foreach (var item in libraryItems)
        {
            Console.WriteLine("The item in the list is:");
            item.Showinfo();
        }
    }
    public void ListBook()
    {
        foreach (var item in BookItems)
        {
            Console.WriteLine("The item in the list is:");
            item.Showinfo();
        }
    }
    public void ListMagazine()
    {
        foreach (var item in Magazines)
        {
            Console.WriteLine("The item in the list is:");
            item.Showinfo();
        }
    }

}

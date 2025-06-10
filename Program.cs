using System;
using library;
Library library = new Library();
try
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Welcome to Library Management");
    Console.ResetColor();
    Book b1 = new Book("1", "Ps1", "Manirathanam", "1234567890987654");
    Book b2 = new Book("2", "Gameofthrones", "Mother of dragons", "4561234567890987");
    Magazine b3 = new Magazine("3", "Co", "4567");
    // b1.displaydetails();
    // b2.displaydetails();
    // b1.Showinfo();
    library.AddItem(b1);
    library.AddItem(b2);
    library.RemoveItem(b2);
    library.AddItem(b3);
    library.ListItems();
    library.ListBook();
    library.ListMagazine();
    // b2.Showinfo();
}

catch (InvalidException e)
{
    Console.WriteLine($"Error:{e.Message}");
}
catch (BookAlreadyExistsException e)
{
    Console.WriteLine($"Error:{e.Message}");
}
// Magazine m1 = new Magazine ("1", "RTYJK", "dfghj" );
// // b2.displaydetails(); ;
// m1.Showinfo();
// Fine f1 = new Fine();
// f1.Finecalculator(5);
// f1.Finecalculator(5, 10);
// f1.Finecalculator(5, 10, "Gold");
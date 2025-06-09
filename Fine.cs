using System;
namespace library;

public class Fine
{
    public int Days { get; set; }
    public double Fineamount { get; set; }
    public string Type { get; set; }
    public Fine(int days, double fineamount, string type)
    {
        Days = days;
        Fineamount = fineamount;
        Type = type;
    }
    public Fine() { }
    public void Finecalculator(int Days)
    {
        Console.WriteLine($"The Fine amount is::{Days * 5}");
    }
    public void Finecalculator(int Days, double Fineamount)
    {
        Console.WriteLine($"The Fine amount is::{Days * Fineamount}");
    }
    public void Finecalculator(int Days, double Fineamount, string Type)
    {
        switch (Type)
        {
            case "Gold":

                Console.WriteLine($"The Fine amount is::{Days * Fineamount * 3}");
                break;
            case "Silver":
                Console.WriteLine($"The Fine amount is::{Days * Fineamount * 3}");
                break;
            case "Platinum":
                Console.WriteLine($"The Fine amount is::{Days * Fineamount * 2}");
                break;
            case "Faculty":
                Console.WriteLine($"The Fine amount is::{(Days * Fineamount) / 2}");
                break;
            default:
                Console.WriteLine($"The Fine amount is::{Days * Fineamount * 5}");
                break;
        }
        
    }
}
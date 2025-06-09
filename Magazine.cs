namespace library;

public class Magazine:Libraryitem
{
    public string Issuenum { get; set; }
    public Magazine(string id, string title, string issuenum) : base(id, title)
    {
        Id = id;
        Title = title;
        Issuenum = issuenum;

    }
    public Magazine() { }
}
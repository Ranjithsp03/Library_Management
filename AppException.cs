namespace library;

public class InvalidException : Exception
{
    public InvalidException(string message) : base(message)
    {

    }
}
public class BookAlreadyExistsException : Exception
{
    public BookAlreadyExistsException(string message) : base(message)
    {

    }
}
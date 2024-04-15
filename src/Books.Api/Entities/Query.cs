namespace Books.Api.Entities;

public class Query
{
    public Book GetBook() => new Book
    {
        Id = 1,
        Title = "Refactoring",
        Author = new Author
        {
            Id = 1,
            Name = "Martin Fowler"
        }
    };
}

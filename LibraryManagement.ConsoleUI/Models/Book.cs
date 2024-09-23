namespace LibraryManagement.ConsoleUI.Models;

// Psikoloji
// pssikoloji
public sealed class Book : Entity
{
    public Book()
    {
        
    }
    public Book(int id,int categoryId, int authorId, string title, string description, int pageSize, string publishDate, string ıSBN) : base(id)
    {
        CategoryId = categoryId;
        AuthorId = authorId;
        Title = title;
        Description = description;
        PageSize = pageSize;
        PublishDate = publishDate;
        ISBN = ıSBN;
    }

    public int CategoryId { get; set; }
    public int AuthorId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int PageSize { get; set; }
    public string PublishDate { get; set; }
    public string ISBN { get; set; }
}
namespace LibraryManagement.ConsoleUI;

public record Book(
    int Id,
    string Title,
    string Description,
    int PageSize,
    string PublishDate,
    string ISBN
    );
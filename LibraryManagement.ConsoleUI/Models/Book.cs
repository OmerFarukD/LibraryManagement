namespace LibraryManagement.ConsoleUI.Models;

public record Book(
    int Id,
    string Title,
    string Description,
    int PageSize,
    string PublishDate,
    string ISBN
    );
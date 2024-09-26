
using LibraryManagement.ConsoleUI.Models;
using LibraryManagement.ConsoleUI.Models.Dtos;

namespace LibraryManagement.ConsoleUI.Repository;

public interface IBookRepository : IRepository<Book,Guid>
{
    List<Book> GetAllBooksByPageSizeFilter(int min, int max);
    double PageSizeTotalCalculator();


    List<Book> GetAllBooksByTitleContains(string text);

    Book? GetBookByISBN(string isbn);

    List<Book> GetAllBookOrderByTitle();

    List<Book> GetAllBookOrderByDescendingTitle();
    Book GetBookMaxPageSize();

    Book GetBookMinPageSize();

    List<BookDetailDto> GetDetails();
    List<BookDetailDto> GetDetailsV2();

    List<BookDetailDto> GetAllAuthorAndBookDetails();
    List<BookDetailDto> GetAllDetailsByCategoryId(int categoryId);

    List<string> GetAllTitles();


}

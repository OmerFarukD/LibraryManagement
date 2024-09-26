using LibraryManagement.ConsoleUI.Models;
using LibraryManagement.ConsoleUI.Models.Dtos;
using LibraryManagement.ConsoleUI.Repository;

namespace LibraryManagement.ConsoleUI.Service;
public class BookService
{

    BookRepository bookRepository = new BookRepository();

    public void GetAll()
    {
        List<Book> books = bookRepository.GetAll();

        foreach (Book book in books) 
        {
            Console.WriteLine(book);
        }
    }

    public void GetById(Guid id)
    {
        Book? book = bookRepository.GetById(id);
        if(book is null)
        {
            Console.WriteLine($"Aradığınız Id ye göre Kitap bulunamadı : {id}");
            return;
        }

        Console.WriteLine(book);

    }

    public void Remove(Guid id)
    {
        Book? deletedBook = bookRepository.Remove(id);
        if (deletedBook is null)
        {
            Console.WriteLine("Aradığınız kitap bulunamadı(Zaten Yok)");
            return;
        }
        Console.WriteLine(deletedBook);
    }

    public void GetBookByISBN(string isbn)
    {
        Book? book = bookRepository.GetBookByISBN(isbn);
        if (book is null) 
        {
            Console.WriteLine($"Aradığınız ISBN numarasına göre kitap bulunamadı. {isbn}");
            return;
        }

        Console.WriteLine(book);
    }


    public void Add(Book book)
    {
        BookIdBusinessRules(book.Id);
        BookISBNBusinessRules(book.ISBN);
        Book created = bookRepository.Add(book);
        Console.WriteLine("Kitap eklendi : ");
        Console.WriteLine(created);
    }

    public void GetAllBooksByPageSizeFilter(int min, int max)
    {
        List<Book> books = bookRepository.GetAllBooksByPageSizeFilter(min,max);

        foreach (Book book in books) 
        {
            Console.WriteLine(book);
        }
    }
    public void GetAllBooksTitleContains(string text)
    {
        List<Book> books = bookRepository.GetAllBooksByTitleContains(text);

        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
    }

    public void GetAllBooksOrderByTitle()
    {
        List<Book> books = bookRepository.GetAllBookOrderByTitle();

        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
    }

    public void GetAllBooksOrderByTitleDescending()
    {
        List<Book> books = bookRepository.GetAllBookOrderByDescendingTitle();

        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
    }

    public void GetBookMinPageSize()
    {
        Book book = bookRepository.GetBookMinPageSize();
        Console.WriteLine(book);
    }


    public void GetBookMaxPageSize()
    {
        Book book = bookRepository.GetBookMaxPageSize();
        Console.WriteLine(book);
    }

    public void GetDetails()
    {
        List<BookDetailDto> books = bookRepository.GetDetails();
        foreach (BookDetailDto bookDetail in books)
        {
            Console.WriteLine(bookDetail);
        }
    }

    public void GetDetailsV2()
    {
        List<BookDetailDto> books = bookRepository.GetDetailsV2();
        foreach (BookDetailDto bookDetail in books)
        {
            Console.WriteLine(bookDetail);
        }
    }

    public void GetAllBookAndAuthorDetails()
    {
        List<BookDetailDto> details = bookRepository.GetAllAuthorAndBookDetails();
        details.ForEach(x=> Console.WriteLine(x));
    }

    public void GetAllDetailsByCategoryId(int categoryId)
    {

        List<BookDetailDto> details = bookRepository.GetAllDetailsByCategoryId(categoryId);
        details.ForEach(x => Console.WriteLine(x));
    }


    private void BookIdBusinessRules(Guid id)
    {
        Book? getByIdBook = bookRepository.GetById(id);
        if (getByIdBook != null)
        {
            Console.WriteLine($"Girmiş olduğunuz kitabın Id Alanı Benzersiz olmalıdır: {id}");
            return;
        }
    }

    private void BookISBNBusinessRules(string isbn)
    {
        Book? getBookByISBN = bookRepository.GetBookByISBN(isbn);
        if (getBookByISBN is not null)
        {
            Console.WriteLine($"Girmiş olduğunuz kitabın ISBN Alanı Benzersiz olmalıdır: {isbn}");
            return;
        }
    }

}

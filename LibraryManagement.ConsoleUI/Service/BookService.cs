using LibraryManagement.ConsoleUI.Models;
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

    public void GetById(int id)
    {
        Book? book = bookRepository.GetById(id);
        if(book is null)
        {
            Console.WriteLine($"Aradığınız Id ye göre Kitap bulunamadı : {id}");
            return;
        }

        Console.WriteLine(book);

    }

    public void Remove(int id)
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

}

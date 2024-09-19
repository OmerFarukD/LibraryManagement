using LibraryManagement.ConsoleUI.Models;
using LibraryManagement.ConsoleUI.Service;

namespace LibraryManagement.ConsoleUI.Repository;

public class BookRepository
{
    List<Book> books = new List<Book>()
{
    new Book(1,"Germinal","Kömür Madeni",341,"2012 Mayıs","9781234567897"),
    new Book(2,"Suç ve Ceza","Raskolnikov un hayatı",315,"2010 Haziran","9781234567891"),
    new Book(3,"Kumarbaz","Bir Öğretmenin hayatı",210,"2009 Ocak","9781234567892"),
    new Book(4, "Araba Sevdası","Arabayla alakası olmayan Kitap",180,"1999 Ocak","9781234567838"),
    new Book(5,"Ateşten Gömlek","Kurtulu savaşını anlatan kitap",120,"2001 Eylül","9781234567834"),
    new Book(6,"Kaşağı","Okunmaması gereken bir kitap",95,"1993 Ocak","9781234567845"),
    new Book(7,"28 Şampiyonluk","Hayal ürünüdür",350,"1907 Ocak ","9781234567807"),
    new Book(8,"16 Yıl Şampiyonluk","Hayal ürünüdür.",255,"10 Eylül","9781234567800"),
    new Book(9,"Ali Arı","Uyanık Ceo nun hikayesi",551,"20 Haziran","9781234567800")
};


    public List<Book> GetAll()
    {
        return books;
    }


    // Language Integrated Query 
    public List<Book> GetAllBooksByPageSizeFilter(int min, int max)
    {
        // Geleneksel Yöntem
        //List<Book> filteredBooks = new List<Book>();

        //foreach (Book book in books)
        //{
        //    if (book.PageSize <= max && book.PageSize >= min)
        //    {
        //        filteredBooks.Add(book);
        //    }
        //}
        //return filteredBooks;

        // LINQ Geleneksel yöntem
        //List<Book> result = (from b in books
        //                    where b.PageSize <= max && b.PageSize >= min
        //                    select b).ToList();

       //  List<Book> result = books.Where(b => b.PageSize <= max && b.PageSize >= min).ToList();


       List<Book> result = books.FindAll(b => b.PageSize <= max && b.PageSize >= min);
        return result;
    }

    public double PageSizeTotalCalculator()
    {
        double total = books.Sum(x=> x.PageSize);
        return total;
    }

    public List<Book> GetAllBooksByTitleContains(string text)
    {
        //List<Book> filteredBooks = new List<Book>();
        //foreach(Book book in books)
        //{
        //    if (book.Title.Contains(text,StringComparison.InvariantCultureIgnoreCase))
        //    {
        //        filteredBooks.Add(book);
        //    }
        //}
        //return filteredBooks;

        List<Book> filteredBooks = books.FindAll(x=> x.Title.Contains(text,StringComparison.InvariantCultureIgnoreCase));
        return filteredBooks;
    }

    public Book? GetBookByISBN(string isbn)
    {
        //Book book1 = null;
        //foreach (Book item in books)
        //{
        //    if (item.ISBN==isbn)
        //    {
        //        book1 = item;
        //    }

        //}
        //if (book1 == null)
        //{
        //    return null;
        //}

        //return book1;

        //Book book = (from b in books where b.ISBN == isbn select b).FirstOrDefault();

        //Book book = books.Where(x => x.ISBN == isbn).SingleOrDefault();

        Book book = books.SingleOrDefault(x => x.ISBN == isbn);
        return book;
    }

    public Book Add(Book created)
    {
        books.Add(created);
        return created;
    }

    public Book? GetById(int id)
    {
        Book? book1 = null;
        foreach (Book book in books)
        {
            if (book.Id==id)
            {
                book1 = book;
            }
        }

        if (book1 == null)
        {
            return null;
        }

        return book1;
    }

    public Book? Remove(int id)
    {
        Book? deletedBook = GetById(id);

        if (deletedBook is null) 
        {
            return null;
        }
        books.Remove(deletedBook);
        return deletedBook;
    }

    public List<Book> GetAllBookOrderByTitle()
    {
        List<Book> orderedBooks = books.OrderBy(b=> b.Title).ToList();
        return orderedBooks;
    }


    public List<Book> GetAllBookOrderByDescendingTitle()
    {
        List<Book> orderedBooks = books.OrderByDescending(b => b.Title).ToList();
        return orderedBooks;
    }

    public Book GetBookMaxPageSize()
    {

    }



    public Book GetBookMinPageSize()
    {

    }
}

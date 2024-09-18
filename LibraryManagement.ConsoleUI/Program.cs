//(Record) Kitap -> Id,Title , Description, PageSize, PublishDate, ISBN , Stock
//(Record) Author -> Id,Name, Surname
//(Cbelass) Category -> Id,Name alanı 


// Category eklerken -> Id veya Name alanları benzersiz olmalı 
// Author eklerken Id (name surname)

//Kitaplar listesi oluşturunuz
//Yazarlar   "         "
//Kategoriler  "       "        


// Yazarları ekrana bastıran kodu yazınız
// Kitapları ekrana bastıran kodu yazınız
// Kategorileri ekrana bastıran kodu yazınız.

// Kitapları Sayfa sayısına göre filtreleyen kodu yazınız.
// Kütüphanedeki tüm kitapların sayfa sayısı toplamını hesaplayan kodu yazınız.
// Kitap başlığına göre filtreleme  işlemleri yapınız
// Kitap ISBN numarasına göre ilgili kitabı getiriniz.

// Kitaplar listesine yeni bir kitap ekleyip eklendikten sonra listeyi ekran çıktısı
// olarak veriniz.(Verileri kullanıcıdan alınız.)
// * Kitap eklerken Id si veya ISBN numarası daha önceki eklenen kitaplarda var ise 
// Benzersiz bir kitap girmeniz gerekmektedir yazısı çıksın.

// Kullanıcı bir Id girdiği zaman o id ye göre kitabı silen ve yeni listeyi ekrana bastıran
// kodu yazınız.


// Kullanıcıdan ilk başta id değeri alıp arama yaptıktan sonra eğer o Id ye ait
// bir kitap yoksa "İlgili Id ye ait bir kitap bulunamadı."
//* Güncellenecek olan değerler kullanıcıdan alınacak.

// Kullanıcıdan bir kitap almasını isteyen kodu yazınız 
// Eğer o kitap Stok da varsa kitap alındı yazısı çıksın 
// 1 tane varsa o kitap alınsın ve 0 olursa Listeden silinsin.



// Prime Örnekler 
// BookDetail adında bir record oluşturup şu değerler listelenecek
// Kitap Id, Kitap Başlığı , Kitap Açıklaması, Kitap Sayfa Sayısı, ISBN ,
// Yazar Adı, Kategori Adı


// Kullanıcıdan PageIndex ve PageSize değerlerini alarak sayfalama desteği getiriniz.


using LibraryManagement.ConsoleUI.Models;
using System.ComponentModel;




List<Author> authors = new List<Author>()
{
    new Author(1,"Emile","Zola"),
    new Author(2,"Fyodor","Dostoyevski"),
    new Author(3,"Recaizade Mahmut","Ekrem"),
    new Author(4, "Halide Edib","Adıvar"),
    new Author(5,"Ömer","Seyfettin"),
    new Author(6,"Ali","Koç"),
    new Author(7,"Vız vız","Ali")
};



List<Category> categories = new List<Category>()
{
    new Category(1,"Dünya Klasikleri"),
    new Category(2,"Türk Klasikleri"),
    new Category(3,"Bilim Kurgu")
};
//GetAllBooksByPageSizeFilter();

GetAllBooks();
//GetAllAuthors();
//GetAllCategories();
//PageSizeTotalCalculator();

//GetAllBooksByTitleContains();

//GetBookByISBN();
AddBook();



Book GetBookInputs2()
{
    Console.WriteLine("Lütfen kitap id sini giriniz: ");
   int id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap başlığını giriniz: ");
    string title = Console.ReadLine();

    Console.WriteLine("Lütfen kitap Açıklamasını giriniz: ");
   string description = Console.ReadLine();

    Console.WriteLine("Lütfen kitap sayfasını giriniz: ");
   int pageSize = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap Yayımlanma Tarihini giriniz: ");
   string publishDate = Console.ReadLine();

    Console.WriteLine("Lütfen kitap ISBN numarasını giriniz: ");
    string isbn = Console.ReadLine();

    Book book = new Book(id, title, description, pageSize, publishDate, isbn);
    return book;
}

bool AddBookValidator(Book book)
{
    bool isUnique = true;

    foreach (Book item in books)
    {
        if (item.Id == book.Id || item.ISBN == book.ISBN)
        {
            isUnique = false;
            break;
        }
    }

    return isUnique;
}

void GetBookInputs(out int id,
     out string title,
     out string description,
     out int pageSize,
     out string publishDate,
     out string isbn)
{
    Console.WriteLine("Lütfen kitap id sini giriniz: ");
    id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap başlığını giriniz: ");
     title = Console.ReadLine();

    Console.WriteLine("Lütfen kitap Açıklamasını giriniz: ");
     description = Console.ReadLine();

    Console.WriteLine("Lütfen kitap sayfasını giriniz: ");
     pageSize = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap Yayımlanma Tarihini giriniz: ");
     publishDate = Console.ReadLine();

    Console.WriteLine("Lütfen kitap ISBN numarasını giriniz: ");
     isbn = Console.ReadLine();
}

void AddBook()
{
    //1. Yöntem
    //int id;
    //string title;
    //string description;
    //int pageSize;
    //string publishDate;
    //string isbn;

    //GetBookInputs(out id,out title,out description,out pageSize,out publishDate,out isbn);
    Book book = GetBookInputs2();

    bool isUnique = AddBookValidator(book);

    if (!isUnique)
    {
        Console.WriteLine("Girmiş olduğunuz kitap Benzersiz değil.");
        return;
    }
    books.Add(book);
    GetAllBooks();
}

void GetBookByISBN()
{
    Console.WriteLine("Lütfen ISBN numarasını giriniz: ");
    string isbn = Console.ReadLine();

    foreach (Book book in books)
    {
        if (book.ISBN == isbn)
        {
            Console.WriteLine(book);
        }
    }
}





void GetAllCategories()
{
    PrintAyirac("Kategorileri Listele");
    foreach (Category category in categories)
    {
        Console.WriteLine(category);
    }
}

void GetAllAuthors()
{
    PrintAyirac("Yazarları Listele: ");
 
    foreach (Author author in authors)
    {
        Console.WriteLine(author);
    }
}

void PrintAyirac(string metin)
{
    Console.WriteLine(metin);
    Console.WriteLine("----------------------------------------");
}


//(Record) Kitap -> Id,Title , Description, PageSize, PublishDate, ISBN , Stock
//(Record) Author -> Id,Name, Surname
//(Class) Category -> Id,Name 


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


using LibraryManagement.ConsoleUI;
using System.ComponentModel;

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

//GetAllBooks();
//GetAllAuthors();
//GetAllCategories();
//PageSizeTotalCalculator();

//GetAllBooksByTitleContains();

//GetBookByISBN();
Add();

void Add()
{
    PrintAyirac("Kitap Ekleme: ");
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

    Book book = new Book(id,title,description,pageSize,publishDate,isbn);

    bool isUnique = true;

    foreach (Book item in books)
    {
        if(item.Id == id || item.ISBN == isbn)
        {
            isUnique = false;
            break;
        }
    }

    if (!isUnique)
    {
        Console.WriteLine("Girmiş olduğunuz kitap Benzersiz değil.");
        return;
    }


    books.Add(book);

    foreach (Book item in books)
    {
        Console.WriteLine(item);
    }

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
void GetAllBooksByTitleContains()
{
    Console.WriteLine("Lütfen kitap başlığını giriniz: ");
    string text = Console.ReadLine();

    foreach (Book book in books)
    {
        if (book.Title.Contains(text,StringComparison.InvariantCultureIgnoreCase))
        {
            Console.WriteLine(book);
        }
    }
}

void PageSizeTotalCalculator()
{
    int total = 0;
    //for (int i =0;i<books.Count;i++)
    //{
    //    total = books[i].PageSize + total;
    //}

    foreach (var item in books)
    {
        total = total + item.PageSize;
    }


    Console.WriteLine(total);
}

void GetAllBooks()
{
    PrintAyirac("Kitapları Listele:");

    foreach (Book book in books)
    {
        Console.WriteLine(book);
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


void GetAllBooksByPageSizeFilter()
{
    PrintAyirac("Sayfa Sayısına göre filtreleme");

    Console.WriteLine("Lütfen minimum değeri giriniz: ");
    int min = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen maximum değeri giriniz: ");
    int max = Convert.ToInt32(Console.ReadLine());

    foreach (Book book in books)
    {
        if(book.PageSize<=max && book.PageSize >= min)
        {
            Console.WriteLine(book);
        }
    }

}
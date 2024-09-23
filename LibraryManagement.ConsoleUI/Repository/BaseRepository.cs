using LibraryManagement.ConsoleUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.ConsoleUI.Repository;

public abstract class BaseRepository
{

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

    List<Book> books = new List<Book>()
{
    new Book(1,1,1,"Germinal","Kömür Madeni",341,"2012 Mayıs","9781234567897"),
    new Book(2,1,2,"Suç ve Ceza","Raskolnikov un hayatı",315,"2010 Haziran","9781234567891"),
    new Book(3,1,2,"Kumarbaz","Bir Öğretmenin hayatı",210,"2009 Ocak","9781234567892"),
    new Book(4,2,3, "Araba Sevdası","Arabayla alakası olmayan Kitap",180,"1999 Ocak","9781234567838"),
    new Book(5,2,4,"Ateşten Gömlek","Kurtulu savaşını anlatan kitap",120,"2001 Eylül","9781234567834"),
    new Book(6,2,5,"Kaşağı","Okunmaması gereken bir kitap",95,"1993 Ocak","9781234567845"),
    new Book(7,3,6,"28 Şampiyonluk","Hayal ürünüdür",350,"1907 Ocak ","9781234567807"),
    new Book(8,3,6,"16 Yıl Şampiyonluk","Hayal ürünüdür.",255,"10 Eylül","9781234567800"),
    new Book(9,3,7,"Ali Arı","Uyanık Ceo nun hikayesi",551,"20 Haziran","9781234567800")
};

    List<Category> categories = new List<Category>()
{
    new Category(1,"Dünya Klasikleri"),
    new Category(2,"Türk Klasikleri"),
    new Category(3,"Bilim Kurgu")
};

    private List<Member> members = new List<Member>()
    {
        new Member
        {
            Id=1,
            Age= 25,
            Name = "Eva",
            Surname = "Neva"
        },
        new Member
        {
            Id=2,
            Name ="Sosyal Ankastre 1",
            Surname = "Sosyal Ankastre 1",
            Age = 25,
        }
    };


    public List<Book> Books()
    {
        return books;
    }

    public List<Category> Categories() 
    {
        return categories;
    }

    public List<Author> Authors()
    {
        return authors;
    }

    public List<Member> Members() 
    {
        return members;
    }

}



using BookProject_Homework.Business;
using BookProject_Homework.Data;
using BookProject_Homework.Models;

IBookService bookService = new BookService(new BookRepository());


Book book = new Book()
{
    ID = 5,
    Description = "Test",
    Price = 1000,
    Stock = 500,
    Title = "Test"
};

//Console.WriteLine("Kayıt ekleme : ");
//bookService.Add(book);

Console.WriteLine("Isbn ye göre getirme:");
bookService.GetByIsnb("G");
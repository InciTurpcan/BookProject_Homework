
using BookProject_Homework.Data;
using BookProject_Homework.Models;
using BookProject_Homework.Exeptions;

namespace BookProject_Homework.Business;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;
    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }
    public void Add(Book book)
    {
        try
        {
            AddRules(book);
            _bookRepository.Add(book);
            GetList();
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }

    public void Delete(int ID)
    {
        try
        {
            _bookRepository.Delete(ID);
            GetList();
        }
        catch (BookNotFoundException ex)
        {

            Console.WriteLine(ex.Message);
        }
                    
    }

    public void GetById(int ID)
    {
        try
        {
            Book? book = _bookRepository.GetByID(ID);
            Console.WriteLine(book);
        }
        catch (BookNotFoundException ex)
        {

            Console.WriteLine(ex.Message);
        }
    }

    public void GetByIsnb(string isnb)
    {
        try
        {
            Book? book = _bookRepository.GetByIsnb(isnb);
            Console.WriteLine(isnb);
        }
        catch (BookNotFoundWithIsbn ex)
        {

            Console.WriteLine(ex.Message);
        }
    }

    public void GetList()
    {
        List<Book> books = _bookRepository.GetAll();
        books.ForEach(book => Console.WriteLine(book));
    }

    private void AddRules(Book book) 
    {
     if (book.Title.Length <2)
     {
            throw new BookTitleException(book.Title);
     }

        if (book.Price<0 || book.Stock<0)
        {
            throw new BookPriceAndStockException(book.Price, book.Stock);
        }

    
    }
}

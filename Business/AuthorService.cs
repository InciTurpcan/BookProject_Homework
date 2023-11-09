

using BookProject_Homework.Data;
using BookProject_Homework.Exeptions;
using BookProject_Homework.Models;

namespace BookProject_Homework.Business;

public class AuthorService : IAuthorService
{
    private readonly IAuthorRepository _authorRepository;

    public AuthorService(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public void Add(Author author)
    {
        try
        {
            Rules(author);
            _authorRepository.Add(author);

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
            _authorRepository.Delete(ID);
            GetList();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetById(int ID)
    {
        try
        {
            Author? author = _authorRepository.GetByID(ID);
            Console.WriteLine(author);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void GetList()
    {
        _authorRepository
            .GetAll()
            .ForEach(a => Console.WriteLine(a));
    }
    private void Rules(Author author)
    {
        if (author.Name.Length < 2)
        {
            throw new AuthorNameException(author.Name);
        }
    }
}

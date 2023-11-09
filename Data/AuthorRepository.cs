
using BookProject_Homework.Models;

namespace BookProject_Homework.Data;

public class AuthorRepository : IAuthorRepository
{
    private readonly List<Author>? _authors;
    public AuthorRepository()
    {
        _authors = new List<Author>
        {
            new Author{ID=1,Name="Arthur Conan Doyle"},
            new Author{ID=2,Name="Dan Brown"},
            new Author{ID=3,Name="Stefan Zweig"},
            new Author{ID=4,Name="J. K. Rowling"},
            new Author{ID=5,Name="David D. Burns"},
            new Author{ID=6,Name="Sigmund Freud"}

        };
    }

    public void Add(Author author)
    {
        _authors.Add(author);
    }

    public void Delete(int ID)
    {
        Author author = _authors.SingleOrDefault(x => x.ID == ID);
        if (author is not null)
        {
            _authors.Remove(author);
        }
    }

    public List<Author> GetAll()
    {
        return _authors.ToList();

    }

    public Author GetByID(int ID)
    {
        Author? author = _authors.FirstOrDefault(x => x.ID == ID);
        if (author is not null)
        {
            return author;
        }
        return null;
    }
}



using BookProject_Homework.Models;

namespace BookProject_Homework.Data;

public interface IBookRepository : IEntityBaseRepository<Book,int>
{
    Book GetByIsnb(string isnb);
}

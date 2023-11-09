

using BookProject_Homework.Models;

namespace BookProject_Homework.Business;

public interface IBookService
{
    void GetList();
    void Add(Book book);
    void Delete(int ID);
    void GetById(int ID);
    void GetByIsnb(string isnb);
}

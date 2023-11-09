

using BookProject_Homework.Models;

namespace BookProject_Homework.Business;

public interface IAuthorService
{
    void GetList();
    void Add(Author author);

    void Delete(int id);

    void GetById(int id);
}

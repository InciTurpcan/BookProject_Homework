
using BookProject_Homework.Models;

namespace BookProject_Homework.Business;

public interface ICategorySevices
{
    void GetList();
    void AddCategory(Category category);
    void Delete(int ID);

    void GetById(int ID);
}

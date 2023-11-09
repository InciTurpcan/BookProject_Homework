

using BookProject_Homework.Data;
using BookProject_Homework.Exeptions;
using BookProject_Homework.Models;

namespace BookProject_Homework.Business;

public class CategoryServices : ICategorySevices
{
    private readonly ICategoryRepository _categoryRepository;
    public CategoryServices(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public void AddCategory(Category category)
    {
        _categoryRepository.Add(category);
        GetList();
    }

    public void Delete(int ID)
    {
        try
        {
            _categoryRepository.Delete(ID);
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
            Category? category = _categoryRepository.GetByID(ID);
            Console.WriteLine(category);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetList()
    {
       _categoryRepository
            .GetAll()
            .ForEach(c=>Console.WriteLine(c));
    }

   
}

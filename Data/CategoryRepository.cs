

using BookProject_Homework.Models;

namespace BookProject_Homework.Data;

public class CategoryRepository : ICategoryRepository
{
    private readonly List<Category>? _categories;

    public CategoryRepository()
    {
        _categories = new List<Category>()
        { 
        new Category{ID=1,Name="Polisiye"},
        new Category{ID=2,Name="Roman"},
        new Category{ID=3,Name="Fantastik"},
        new Category{ID=4,Name="Polisiye"},
        new Category{ID=5,Name="Psikoloji"}
        };
    }
    public void Add(Category category)
    {
        _categories.Add(category);

    }

    public void Delete(int ID)
    {
        Category category = _categories.SingleOrDefault(x => x.ID == ID);
        if (category is not null)
        {
            _categories.Remove(category);
        }
        
    }

    public List<Category> GetAll()
    {
        return _categories.ToList();
    }

    public Category GetByID(int ID)
    {
        Category? category =_categories.FirstOrDefault(x => x.ID == ID);
        if (category is not null) 
        {
        return category;
        }
        return null;
    }
}

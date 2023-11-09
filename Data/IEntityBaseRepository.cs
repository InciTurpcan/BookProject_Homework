

namespace BookProject_Homework.Data;

public interface IEntityBaseRepository<TEntity,TID>
{
    void Add(TEntity category);
    void Delete(TID ID);
    List<TEntity> GetAll();
    TEntity GetByID(TID ID);
}

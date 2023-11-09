

namespace BookProject_Homework.Models;

public abstract class EntityBase<TID>
{
    public TID? ID { get; set; }
}

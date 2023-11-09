

namespace BookProject_Homework.Models;

public class Category:EntityBase<int>
{
    public string? Name { get; set; }

    public override string ToString()
    {
        return $"ID : {ID}, İsim : {Name}";
    }
}

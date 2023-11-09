

namespace BookProject_Homework.Models;

public class Book:EntityBase<int>
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public int CategoryID { get; set; }
    public int AuthorID { get; set; }
    public string? Isbn { get; set; }

    public override string ToString()
    {
        return $"ID :{ID}, Başlık : {Title}, Açıklama : {Description}, Değeri : {Price}, Stok : {Stock}, KategoriID : {CategoryID}, YazarID : {AuthorID},Isnb : {Isbn}";
    }

}

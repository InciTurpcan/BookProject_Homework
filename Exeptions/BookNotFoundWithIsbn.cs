

namespace BookProject_Homework.Exeptions;

public class BookNotFoundWithIsbn : Exception
{
    public BookNotFoundWithIsbn(string isnb) : base($"Isbn : {isnb}, ye ait kitap bulunamadı.")
    {

    }
}

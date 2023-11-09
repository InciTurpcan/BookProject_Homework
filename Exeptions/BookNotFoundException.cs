

namespace BookProject_Homework.Exeptions;

public class BookNotFoundException :Exception
{
    public BookNotFoundException(int ID) : base($"ID : {ID}, ye ait kitap bulunamadı.")
    {
    
    }
}



using BookProject_Homework.Consts;

namespace BookProject_Homework.Exeptions;

public class BookPriceAndStockException :Exception
{
    public BookPriceAndStockException(double price, int stock) : base(Messages.BookPriceAndStockExceptionMessage(price, stock))
    { }
}

using BookProject_Homework.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject_Homework.Exeptions;

public class BookTitleException : Exception
{
    public BookTitleException(string title) : base (Messages.BookTitleExceptionMessage(title))
    {

    }
    
}



using BookProject_Homework.Consts;

namespace BookProject_Homework.Exeptions;

public class AuthorNameException : Exception
{
    public AuthorNameException(string name) : base(Messages.AuthorNameExceptionMessage(name))
    { }
}

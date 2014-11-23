using System;

public class DocumentInvalidException : ApplicationException
{
    public DocumentInvalidException()
        : base()
    {

    }

    public DocumentInvalidException(string msg)
        : base(msg)
    {

    }
}


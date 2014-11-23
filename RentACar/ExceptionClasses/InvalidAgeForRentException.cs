using System;

public class InvalidAgeForRentException : ApplicationException
{
    public InvalidAgeForRentException()
        : base()
    {

    }

    public InvalidAgeForRentException(string msg)
        : base(msg)
    {

    }
}


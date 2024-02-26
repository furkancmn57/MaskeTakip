using Business.Concrete;
using Entities.Concrete;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Person person = new Person
        {
            FirstName = "FURKAN",
            LastName = "ÇİMEN",
            DateOfBirthYear = 2003,
            NotionalIdentity = 12345
        };
        PttManager pttManager = new PttManager(new PersonManager());

        pttManager.GiveMask(person);

    }
}
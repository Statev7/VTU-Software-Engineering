namespace _02_BankApp.Utilities.Exceptions
{
    using System;

    public class EntityDoesNotExistException : Exception
    {
        public EntityDoesNotExistException(string message)
            :base(message)
        {

        }
    }
}

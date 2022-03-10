namespace _02_BankApp.Utilities.Exceptions
{
    using System;

    public class ClientAlreadyRegistreted : Exception
    {
        public ClientAlreadyRegistreted(string message)
            :base(message)
        {

        }
    }
}

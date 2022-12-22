﻿using System;

namespace Excecoes.Entities.Exceptions
{
    class DomainException : ApplicationException
    {

        public DomainException(string message) : base(message)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_Exceptions.Exceptions;

public class AgeException : Exception
{
    public AgeException(string erorMessage) : base(erorMessage)
    {

    }
}

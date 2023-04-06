using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Exceptions
{
    public class NotExistTriangleException : Exception
    {
        public NotExistTriangleException(string message) : base(message)
        {
        }
    }
}

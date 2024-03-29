using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SoldeInsuffisantException : Exception
    {
        string message;
        public SoldeInsuffisantException()
        {
            message = "pas assez de thune";
        }

        public SoldeInsuffisantException(string? message) : base(message)
        {
            this.message = message;
            Console.WriteLine(message);
        }

        public SoldeInsuffisantException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected SoldeInsuffisantException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}


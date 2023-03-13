using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesProgram
{
    public class ExceptionStateCensus : Exception
    {
        public enum ExceptionTypes
        {
            FILE_INCORRECT_PATH,
            TYPE_INCORRECT
        }
        public ExceptionTypes type;
        public ExceptionStateCensus(ExceptionTypes type, string message) : base(message)
        {
            this.type=type;
        }
    }
}

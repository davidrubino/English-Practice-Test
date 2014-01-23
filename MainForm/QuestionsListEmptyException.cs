using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    
    [Serializable]
    class QuestionsListEmptyException : System.Exception
    {

        private string message;

        public QuestionsListEmptyException()
        {
            this.message = "No more questions in the list.";
        }

        public QuestionsListEmptyException(string message, Exception innerException) : base(message, innerException)
        {
            this.message = message;
        }

        protected QuestionsListEmptyException(SerializationInfo info, StreamingContext context): base(info, context)
        {

        }

        public string GetMessage()
        {
            return this.message;
        }

    }
}

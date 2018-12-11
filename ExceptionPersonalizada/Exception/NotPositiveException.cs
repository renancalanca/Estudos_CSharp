using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class NotPositiveException : Exception
    {
        /*Para criar uma classe de exception é necessário herdar*/
        public NotPositiveException() : base("O número inserido deve ser positivo.") { }
        /*No construtor voce passa uma string se quiser implementar a mensagem de erro*/
        /*Porque o construtor precisa herdar de base?*/
        public NotPositiveException(string message) : base("O número inserido deve ser positivo.") { }
    }
}

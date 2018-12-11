using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenacaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ao se utilizar do StringBuilder, ao concatenar uma string ele não aloca um novo espaço de memória. Ele aumenta o espaço da memória atual,
             o que torna mais perfomático e evita lixo na memória*/

            var x = "ab";
            var y = "cd";
            var z = "ef";

            var append = StringBuilderAppend(x, y, z);
       
            var appendLine = StringBuilderAppendline(x, y, z);

            var appendFormat = StringBuilderAppendFormat(x, y, z);

            Console.WriteLine("Append: {0}\nAppendLine: {1}\nAppendFormat: {2}", append, appendLine, appendFormat);
            Console.ReadLine();

            /*Existe alguma diferença real do String.Concat e do "a" + "b"*/
        }

        private static string StringBuilderAppend(string x, string y, string z)
        {
            /*Adiciona a string na frente da anterior.
             Para pular linha pode utilizar o comando \n*/
            StringBuilder sb = new StringBuilder();

            sb.Append(x);
            sb.Append(y);
            sb.Append(z);

            return sb.ToString();
        }

        private static string StringBuilderAppendline(string x, string y, string z)
        {
            /*O Appendline adiciona um \n no final, sempre que voce utilizar*/
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(x);
            sb.AppendLine(y);
            sb.AppendLine(z);

            return sb.ToString();
        }

        private static string StringBuilderAppendFormat(string x, string y, string z)
        {
            /*Voce passa as posições da string que deseja e monta também da forma que deseja*/
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}  {1}  {2}", x, y, z);

            return sb.ToString();
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace EstudoRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Links auxiliares
             * - https://docs.microsoft.com/pt-br/dotnet/standard/base-types/regular-expression-language-quick-reference
             * - https://regexr.com/ */

            var resposta = Console.ReadLine();

            /*Tipos de reposta do Regex*/
            #region IsMatch
            /*Retorna um bool caso de certo o Regex*/

            if (RegexPlacaDeCarroIsMatch(resposta))
            {
                Console.WriteLine("Valor inserido correto");
            }
            else
            {
                Console.WriteLine("Valor inserido incorreto");
            }
            #endregion
        
            #region Matches
            /*Retorna uma MatchCollection*/

            var mathCol = RegexPlacaDeCarroMatches(resposta);
            if(mathCol.Count > 0)
            {
                Console.WriteLine("Deu certo");
            }
            else
            {
                Console.WriteLine("Não deu certo");
            }

            #endregion

            #region Match

            var match = RegexPlacaDeCarroMatch(resposta);
            if (match.Success)
            {
                Console.WriteLine("Match Success");
            }
            else
            {
                Console.WriteLine("Match No Success");
            } 
            #endregion

            Console.ReadLine();
        }

        private static bool RegexPlacaDeCarroIsMatch(string parametro)
        {
            Regex rx = new Regex(@"^[a-zA-Z]{3}\-\d{4}$");
            return rx.IsMatch(parametro);            
        }

        private static MatchCollection RegexPlacaDeCarroMatches(string parametro)
        {
            Regex rx = new Regex(@"^[a-zA-Z]{3}\-\d{4}$");
            return rx.Matches(parametro);
        }

        private static Match RegexPlacaDeCarroMatch(string parametro)
        {
            Regex rx = new Regex(@"^[a-zA-Z]{3}\-\d{4}$");
            return rx.Match(parametro);
        }

    }
}

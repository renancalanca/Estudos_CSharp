using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversão
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado = ConversaoExplicita(2.0);
            Console.WriteLine("Resultado = {0}", resultado);
            Console.ReadLine();
        }

        private static int ConversaoExplicita(double param)
        {
            /*Na conversão explicita voce coloca o tipo de dado que está convertendo explicitamente*/

            int s1;

            #region CAST
            /*Esse tipo de conversão é chamado de CAST*/
            s1 = (int)param;

            #endregion

            #region PARSE

            /*Esse tipo de parse só converte valor vindo de string*/
            s1 = int.Parse(param.ToString());

            #endregion

            #region CONVERT

            /*O Convert possui diversas sobrecargas, portanto aceita mais parametros*/
            s1 = Convert.ToInt32(param);

            #endregion

            #region TryParse

            /*O método TryParse não lançará uma exception caso dê errado a conversão, pois ele retorna um boolean.
             Esse é o método mais seguro para conversão e você pode colocar num IF como mostra o codigo comentado*/
            bool resultado = int.TryParse(param.ToString(), out s1);
            //if (resultado)
            //    return s1;
            //else
            //    return 0;

            #endregion

            return s1;
        }
    }
}

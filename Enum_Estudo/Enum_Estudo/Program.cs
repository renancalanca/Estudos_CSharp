using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Quando utilizado o | (pipe) signifca que o valor de antesDeAbril são todos aqueles, ou seja, voce passa varios num para mesma variavel*/

            var semFlagIndiceNormal = (JpSemFlagIndiceNormal.Renan | JpSemFlagIndiceNormal.Gabriel).ToString();
            var comFlagIndiceNormal = (JpComFlagIndiceNormal.Renan | JpComFlagIndiceNormal.Gabriel).ToString();
            var semFlag = (JpSemFlag.Renan | JpSemFlag.Gabriel).ToString();
            var comFlag = (JpComFlag.Renan | JpComFlag.Gabriel).ToString();

            /*Indice Identity*/
            Console.WriteLine("Indice Identity = {0}", semFlagIndiceNormal);
            /*Indice Identity e com [FLAGS]*/
            Console.WriteLine("Indice Identity e com [FLAGS] = {0}", comFlagIndiceNormal);
            /*Indice Binario*/
            Console.WriteLine("Indice Binario = {0}", semFlag);

            /* Modo correto de usar o enum quando se vai adicionar multiplos valores a uma variavel
             * Indice Binario e com [FLAGS]
             */
            Console.WriteLine("Indice Binario e com [FLAGS] = {0}", comFlag);

            Console.ReadKey();
        }

        public enum JpSemFlagIndiceNormal
        {
            Renan = 1,
            Gabriel = 2,
            Marcos = 3,
            Betao = 4,
            Najla = 5
        }

        [Flags]
        public enum JpComFlagIndiceNormal
        {
            Renan = 1,
            Gabriel = 2,
            Marcos = 3,
            Betao = 4,
            Najla = 5

        }
        /*
         * Binário:
            000000 = 0
            000001 = 1
            000010 = 4
            000100 = 8
            001000 = 16
                        */
        public enum JpSemFlag
        {
            Renan = 1,
            Gabriel = 2,
            Marcos = 4,
            Betao = 8,
            Najla = 16
        }

        [Flags]
        public enum JpComFlag
        {
            Renan = 1,
            Gabriel = 2,
            Marcos = 4,
            Betao = 8,
            Najla = 16

        }

    }
}

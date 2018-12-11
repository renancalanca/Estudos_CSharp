using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefEstudo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var i = 0;
            Console.WriteLine("Valor = {0}", i.ToString());
            // Ao passar um parametro por Ref é necessário indicar.
            RefAddUm(ref i);
            Console.WriteLine("Valor após chamar o método passando a variavel por Ref.");
            Console.WriteLine("Valor = {0}", i.ToString());
            Console.ReadLine();

            /*Obs:
                Por exemplo voce possui o objeto pessoa e passa por fala que o Renan = Gabriel
                todos os atributos do Gabriel será transferido para o Renan caso sejam exatamente o mesmo.*/
        }

        private static void RefAddUm (ref int param)
        {
			// Obrigado a passar o parametro REF
            /* Ao passar um parametro utilizando o REF, voce altera o valor dele diretamente no endereço de memória, ou seja, 
             * voce não precisa retornar o valor dele para uma variavel.*/
            param = param + 1;
        }

    }
}

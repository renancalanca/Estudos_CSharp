using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_ParametroOpcional_ParametroNomeado
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se você não colocar o parametro opcional, por padrão ele irá chamar o primeiro metodo, em que só tem a string como parametro*/
            Pessoa("Renan");
            Console.WriteLine("\n");

            #region Parametro Nomeado

            /*Colocando os parametros desse jeito você consegue inverter a ordem na hora de chamar o método*/
            Imprimir(int1: 1, string1: "String1", string2: "String2", int2: 2);

            #endregion

            Console.ReadLine();
        }

        #region Overload + Parâmetros Opcionais
        /*Caso você tenha um método com parametro opcional e voce chama o primeiro metodo. Qual que o C# vai chamar por padrão?*/
        private static void Pessoa(string nome)
        {
            Console.WriteLine(nome);
        }

        private static void Pessoa(string nome,int idade = 1)
        {
            Console.WriteLine(nome +" " + idade.ToString());
        }

        #endregion

        private static void Imprimir (string string1, int int1, int int2, string string2)
        {
            Console.WriteLine(string1 + " " + int1.ToString() + " " + int2.ToString() + " " + string2);
        }
    }
}

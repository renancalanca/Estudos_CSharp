using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutEstudo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*O out serve para um metodo poder retornar varios valores e tratar diferentes regras, 
             *por exemplo eu posso ter um metodo que retorne um bool mais dois parametros out que fazem alguma conta*/

            string value;
            SetString2(1, out value);
            Console.WriteLine(value);
            Console.ReadLine();	

            /*Um exemplo do out seria o TryParse*/
			//Usando o out obriga a pessoa a retornar um valor no método
        }

        private static void SetString2(int number, out string value)
        {
            if (number == 1)
            {
                value = "um";
            }
            else
            {
                value = "outro valor"; 
            }
        }
    }
}

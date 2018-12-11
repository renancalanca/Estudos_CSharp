/*É necessário colocar o DEFINE em cima para especificar qual tipo de compilção você esta usando*/
#define RENAN
//#define Debug
//#define Release
using System;

/*Ao compilar ele criara dentro da pasta BIN as pastas de compilação, que seria no caso do exemplo RENAN, Debug e Release*/

namespace Compilacao_Dinamica
{
    class Program
    {
        static void Main(string[] args)
        {

#if RENAN
            Console.WriteLine("RENAN");
#endif
//#if DEBUG (se colocar em letra maiscula do DEBUG ele será sempre como padrão, ou seja, sempre vai compilar do modo dele também)
#if Debug
            Console.WriteLine("DEBUG"); 
#endif

#if Release
            Console.WriteLine("RELEASE");
#endif

            Console.ReadKey();
        }

    }
}

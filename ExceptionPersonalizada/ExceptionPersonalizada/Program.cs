using CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPersonalizada
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var x = Console.ReadLine();
                var y = Console.ReadLine();

                ValidateNumber(int.Parse(x));
                ValidateNumber(int.Parse(y));

                var resultado = (int.Parse(x) / int.Parse(y));


            }
            catch (NotPositiveException npt)
            {
                Console.WriteLine(npt);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }
        private static void ValidateNumber(int number)
        {
            //Caso seja menor que 0 ele cria a exception personalizada e manda a mensagem padrão
            if (number < 0)
                throw;
        }
    }
}

using System;
using System.Diagnostics;

namespace EventLogEstudo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                - A classe EventLog possui 4 construtores: 
                    -EventLog log = new EventLog()
                    -EventLog log = new EventLog(string logName)
                    -EventLog log = new EventLog(string logName, string machineName)
                    -EventLog log = new EventLog(string logName, string machineName, string source)

                    A classe event log herda da ISupportInitialize por isso possui esses dois métodos
                    - log.BeginInit();
                    - log.EndInit();
             */
            try
            {
                using (EventLog log = new EventLog())
                {
                    //É possível passar no construtor.
                    log.Source = "EventLogEstudo";

                    //Se colocar algum nome que não existe irá cair na exception -> ArgumentException
                    log.Log = "Aplicativo";
                   
                    //WriteEntrey serve para escrever no log a mensagem que deseja.
                    log.WriteEntry("Testando log do windows2");
                }
                Console.WriteLine("Deu certo eeee");
            }
            catch (ArgumentException ae)
            {
                /*
                    Execessão acontece quando colocado o nome do log errado.
                 */
                Console.WriteLine("ArgumentExeception");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}

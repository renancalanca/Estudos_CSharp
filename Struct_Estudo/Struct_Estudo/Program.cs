using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilizando o construtor
            Pessoa rena = new Pessoa("Renan", 50);

            //Adicionando valor das propriedas da struct
            Pessoa pesado = new Pessoa();
            pesado.Peso = 150;
            pesado.Nome = "Pesado";

            Console.WriteLine(rena.Peso.ToString());

            //Resultado será 0 pois não passará na verificação do Peso
            Console.WriteLine(pesado.Peso.ToString());

            Console.ReadKey();
        }
    }

    /*Criação da Struct Pessoa*/
    public struct Pessoa
    {
        public string Nome;

        float _peso;
        /*Eu consigo por exemplo, verificar a variavel e só adicionar valor se passar na validação*/
        public float Peso
        {
            get { return _peso; }
            set
            {
                if (value < 100)
                {
                    _peso = value;
                }
            }
        }

        //Construtor da Struct Pessoa
        public Pessoa(string pNome, float pPeso)
        {
            Nome = pNome;
            _peso = pPeso;
        }
    }

}

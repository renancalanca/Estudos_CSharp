using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsEstudo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Queue
            //Declarar Queue (Fila)
            var fila = new Queue<int>();
            //Adicionar valor a fila            
            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(3);
            fila.Enqueue(4);
            Console.WriteLine("Fila:");
            PrintarCollections(fila);
            /*Eliminará o primeiro item da fila
             - Se colocar num foreach é possivel limpar tudo*/

            fila.Dequeue();

            Console.WriteLine("Fila após Dequeue:");
            PrintarCollections(fila);
            //Elimina todos os itens da fila
            fila.Clear();
            #endregion

            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////\n");

            #region Stack
            var pilha = new Stack<int>();
            //Insere item no topo da pilha
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);
            pilha.Push(4);
            Console.WriteLine("Pilha:");
            PrintarCollections(pilha);
            //Remova o item no topo da pilha
            pilha.Pop();
            Console.WriteLine("Pilha após Pop:");
            PrintarCollections(pilha);

            //Limpar todos os elementos da pilha
            pilha.Clear();
            #endregion

            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////\n");

            #region Dictionary
            /*Semelhante ao HashMap do Java*/
            var dicionario = new Dictionary<int, string>();
            dicionario.Add(1, "Renan");
            dicionario.Add(2, "Gabriel");
            dicionario.Add(3, "Marcos");
            dicionario.Add(4, "Felipe");
            /*Se eu adiocionar dois elementos iguals ele da uma Exception ArgumentException 
             dicionario.Add(1, "Renan");*/
            Console.WriteLine("Dicionário:");
            //Ao passar pro metodo generico ele concatena e imprime -> chave , valor 
            PrintarCollections(dicionario);

            Console.WriteLine("Dicionário (Valor):");
            //Fazendo dessa maneira ele irá imprimir somente o valor do dictionary
            foreach (var item in dicionario.Values)
            {
                Console.WriteLine("{0}", item);
            }

            #endregion

            #region List
            var lista = new List<int>();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);

            /*Caso retorne mais que um resultado é necessário dar o ToList() no final*/
            var lstInteiro = lista.Where(p => p == 1).ToList();
            /*Se tiver certeza que retornará somente um ou voce deseja somente um utilize o FirstOrDefault()*/
            var inteiro = lista.Where(p => p == 1).FirstOrDefault();

            var listaForEach = new List<object>();

            /*ForEach utilizando Lambda Expression*/
            lista.ForEach(p =>
              {
                  listaForEach.Add(p);
              }
            );
            
            /*Tentar depois fazer Join utilizando Lambda com as duas listas*/

            #endregion

            Console.ReadKey();
        }

        public static void PrintarCollections(ICollection param)
        {
            foreach (var item in param)
            {
                Console.WriteLine("{0}", item);
            }
        }
    }
}

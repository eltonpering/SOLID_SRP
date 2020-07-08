using System;

namespace CursoFoop_SRP_Aderente
{
    class Program
    {
        static void Main(string[] args)
        {

            Pedido pedido = new Pedido();
            pedido.IncluirPedido();

            pedido.DeletaPedido();

            Console.ReadLine();
        }
    }
}

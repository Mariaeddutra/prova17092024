using System;

namespace CrudVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicialize o seu contexto de banco de dados aqui
            var context = new VeiculoDbContext();

            // Execute as operações de CRUD aqui
            // ...

            Console.ReadLine();
        }
    }
}
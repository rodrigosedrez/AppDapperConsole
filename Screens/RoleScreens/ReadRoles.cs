using System;
using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog.Screens
{
    class ReadRoles
    {
        public static void ReadAll(SqlConnection connection)
        {
            Console.Clear();
            var repository = new Repository<Role>(connection);
            var elementos = repository.GetAll();


            foreach (var item in elementos)
                Console.WriteLine($"Nome: -{item.Name}  Slug:  -{item.Name} \n");

            Console.ReadLine();
            Blog.Screens.RolesMenu.Menu(connection);
        }
    }
}
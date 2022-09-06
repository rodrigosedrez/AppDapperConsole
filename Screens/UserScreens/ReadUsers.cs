using System;
using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog.Screens.Userscreens
{
    class ReadUsers
    {
        public static void ReadAll(SqlConnection connection)
        {
            Console.Clear();
            var repository = new Repository<User>(connection);
            var elementos = repository.GetAll();

            foreach (var item in elementos)
                Console.WriteLine($"ID: {item.id}, Nome:{item.Name}");

            Console.ReadLine();
            Blog.Screens.Userscreens.UserMenu.Menu(connection);
        }
    }
}
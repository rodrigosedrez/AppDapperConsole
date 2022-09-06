using System;
using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;

namespace Blog.Screens.Userscreens
{
    public class DeleteUser
    {


        public static void MenuDelete(SqlConnection connection)
        {
            Console.Clear();
            Console.WriteLine("Selecione um Usuario (usando seu id) a ser deletado:");
            var id = Console.ReadLine();

            Delete(int.Parse(id), connection);
            Console.ReadLine();
            Blog.Screens.Userscreens.UserMenu.Menu(connection);
        }

        public static void Delete(int id, SqlConnection connection)
        {
            try
            {
                var repository = new Repository<User>(connection);
                repository.Delete(id);
                Console.WriteLine("Tag exluída com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível exluir a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}

using System;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string connectionString = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$";
        static void Main(string[] args)
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            MenuPrincipal(connection);
            connection.Close();
        }
        public static void MenuPrincipal(SqlConnection connection)
        {
            //texto do menu principal
            Console.Clear();
            Console.WriteLine("Pesquiza no banco de dados:");
            Console.WriteLine("1 - USUARIO \n");
            Console.WriteLine("2 - PERFIL \n");
            Console.WriteLine("3 - TAG \n");
            Console.WriteLine("4 - POST \n");
            Console.WriteLine("5 - CATEGORY");

            Console.WriteLine("0 - sair \n");
            var opc = Console.ReadLine();

            //elementos de escolha do menu principal

            switch (opc)
            {
                case "1": Blog.Screens.Userscreens.UserMenu.Menu(connection); break;
                case "2": Blog.Screens.RolesMenu.Menu(connection); break;
                case "3": Blog.Screens.TagMenu.Menu(connection); break;
                case "4": Blog.Screens.PostMenu.Menu(connection); break;
                case "5": Blog.Screens.CategoryMenu.Menu(connection); break;
                case "0": Console.Clear(); Environment.Exit(0); break;
                default: MenuPrincipal(connection); break;
            }
        }
    }
}

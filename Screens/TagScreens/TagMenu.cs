using System;
using Microsoft.Data.SqlClient;

namespace Blog.Screens
{
    public class TagMenu
    {
        public static void Menu(SqlConnection connection)
        {
            //texto do menu do usuario
            Console.Clear();
            Console.WriteLine("Menu Tag's o que deseja fazer:");
            Console.WriteLine("1 - Pesquizar todas as Tag's do banco \n");
            Console.WriteLine("2 - Pesquizar somente um usuario do banco \n");
            Console.WriteLine("3 - Criar nova Tag \n");
            Console.WriteLine("4 - Atualizar Tag \n");
            Console.WriteLine("5 - Deletar Tag \n");
            Console.WriteLine("6 - Vincular uma a um Post \n");
            Console.WriteLine("9 - Retornar ao Menu anterior \n");

            Console.WriteLine($"0 - sair \n");
            var opc = Console.ReadLine();

            //elementos de escolha do menu de usuarios

            switch (opc)
            {
                // case "1": Blog.Screens.ReadUsers.ReadAll(connection); break;
                // case "2": Blog.Screens.ReadUser.Read(connection); break;
                // case "3": Blog.Screens.CreateTag.Create(connection); break;
                // case "9": Blog.Program.MenuPrincipal(connection); break;
                case "0": Console.Clear(); Environment.Exit(0); break;
                default: Menu(connection); break;
            }

        }

    }
}
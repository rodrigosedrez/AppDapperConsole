using System;
using Microsoft.Data.SqlClient;

namespace Blog.Screens
{
    public class RolesMenu
    {
        public static void Menu(SqlConnection connection)
        {
            //texto do menu do usuario
            Console.Clear();
            Console.WriteLine("Menu de perfil o que deseja fazer:");
            Console.WriteLine("1 - Pesquizar todos os perfis do banco \n");
            Console.WriteLine("2 - Criar novo perfil \n");
            Console.WriteLine("3 - Atualizar perfil \n");
            Console.WriteLine("4 - Deletar perfil \n");
            Console.WriteLine("9 - Retornar ao Menu anterior \n");
            Console.WriteLine("0 - sair \n");
            var opc = Console.ReadLine();

            //elementos de escolha do menu de Perfil

            switch (opc)
            {
                case "1": Blog.Screens.ReadRoles.ReadAll(connection); break;
                case "2": Blog.Screens.CreateRole.Create(connection); break;
                case "3": Blog.Screens.UpdateRole.Update(connection); break;
                case "9": Blog.Program.MenuPrincipal(connection); break;
                case "0": Console.Clear(); Environment.Exit(0); break;
                default: Menu(connection); break;
            }

        }
    }
}
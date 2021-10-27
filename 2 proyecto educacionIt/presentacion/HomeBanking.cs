using System;
using _2_proyecto_educacionIt.utilidades;

namespace _2_proyecto_educacionIt
{
    class HomeBanking
    {
        static void Main(string[] args)
        {
             Ingreso();
        }

        public static void Ingreso()
        {

            var consola = new InterfaceConsola();
            var UsuarioPorDefecto = new Usuario();
            var ui = new helpersUI();
            var Login = new Mapeo();
            int intentos = 0 ; 

            Console.WriteLine(ui.bienvenida());
            do
            {
               var claveToken = new Token();
               Console.WriteLine(ui.claveToken(claveToken));
               intentos ++;
                    try{
                        var NuevoUsuario = consola.NuevoUsuario();
                        if(Login.Comprobacion(NuevoUsuario, UsuarioPorDefecto, claveToken.token))
                        {
                            System.Console.WriteLine(ui.credencialesCorrectas());
                            break;
                        }
                        else
                        {
                            System.Console.WriteLine(ui.errorCredenciales());
                            var respuesta = Console.ReadLine();
                            switch(respuesta.ToLower())
                            {
                                case "s":
                                break;
                                case "n":
                                System.Console.WriteLine(ui.despedida());
                                return;
                            }
                        }
                    }
                    catch
                    {
                        System.Console.Write(ui.errorCredenciales());
                            var respuesta = Console.ReadLine();
                            switch(respuesta.ToLower())
                            {
                                case "s":
                                break;
                                case "n":
                                System.Console.WriteLine(ui.despedida());
                                return;
                            }
                    }
                }while(Login.BloqueoDeCuenta(intentos));
        }
    }

}

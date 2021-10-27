using System;
using _2_proyecto_educacionIt.utilidades;

namespace _2_proyecto_educacionIt
{
    public class InterfaceConsola
    {
           public ConsolaUsuario NuevoUsuario()
        {
               var ui = new helpersUI();
            
                System.Console.Write(ui.Ingresos("nombre de usuario"));
                string usuario = Console.ReadLine();

                System.Console.Write(ui.Ingresos("contraseña"));
                string contraseña =  Console.ReadLine();

                System.Console.Write(ui.Ingresos("clave token"));
                string token = Console.ReadLine();
                
                return new ConsolaUsuario(){
                    Usuario = (usuario).Trim(), 
                    Password = (contraseña).Trim(),
                    token = Int32.Parse((token.Trim()))
                };
        }
    }
}
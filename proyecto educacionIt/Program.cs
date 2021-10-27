using System;

namespace proyecto_educacionIt
{
    class Program
    {
        static void Main(string[] args)
        {
             Ingreso();
        }

        public static void Ingreso()
        {

            var claveToken = new Token();
            var consola = new InterfaceConsola();
            var UsuarioPorDefecto = new Usuario();
            var Login = new Mapeo();
            int intentos = 0 ; 

            Console.WriteLine($"\nBienvenido a Online Banking, por favor ingrese las credenciales solicitadas\n");
            Console.WriteLine($"\n\tClave Token Generada Automaticamente: {claveToken.token}\n");
            do
            {
               intentos ++;
                    try{
                        var NuevoUsuario = consola.NuevoUsuario();
                        if(Login.Comprobacion(NuevoUsuario, UsuarioPorDefecto, claveToken.token))
                        {
                            System.Console.WriteLine("\nCredenciales correctas, bienvenido a su Online Backing\n");
                            break;
                        }
                        else
                        {
                            System.Console.WriteLine("\n Error de credenciales... desea volver a intentar? (S/N)");
                            var respuesta = Console.ReadLine();
                            switch(respuesta.ToLower())
                            {
                                case "s":
                                break;
                                case "n":
                                System.Console.WriteLine("Gracias por utilizar Online Backing");
                                return;
                            }
                        }
                    }
                    catch
                    {
                        System.Console.Write("\n Error de credenciales... desea volver a intentar? (S/N)");
                            var respuesta = Console.ReadLine();
                            switch(respuesta.ToLower())
                            {
                                case "s":
                                break;
                                case "n":
                                System.Console.WriteLine("\nGracias por utilizar Online Backing");
                                return;
                            }
                    }
                }while(Login.BloqueoDeCuenta(intentos));
        }
    }
    public class InterfaceConsola
    {
        public ConsolaUsuario NuevoUsuario()
        {
            
                System.Console.Write("Ingrese nombre de usuario: ");
                string usuario = Console.ReadLine();

                System.Console.Write("Ingrese contraseña: ");
                string contraseña =  Console.ReadLine();

                System.Console.Write("Ingrese token: ");
                string token = Console.ReadLine();
                
                return new ConsolaUsuario(){
                    Usuario = (usuario).Trim(), 
                    Password = (contraseña).Trim(),
                    token = Int32.Parse((token.Trim()))
                };
        }
    }
    public class Mapeo
    {
        public bool Comprobacion(ConsolaUsuario usuarioIngresado, Usuario usuarioDB, int claveToken)
        {
 
            if((usuarioIngresado.Usuario).ToUpper() != (usuarioDB.usuario).ToUpper())
            {
                return false;
            }
            
            if(usuarioIngresado.Password != usuarioDB.password)
            {
                return false;
            }

            if( usuarioIngresado.token != claveToken)
            {
                return false;
            }

            return true;

        }

        public bool BloqueoDeCuenta(int intentos)
        {
            
            if(intentos != 3)
            {
                return true; 
            }
            Console.WriteLine("Usuario Bloqueado, por favor dirijase a la sucursal mas cercana");
            return false;
        }
    }

    public class ConsolaUsuario
    {
        public string Usuario { get; set; }
        public string Password { get; set; }
        public int token { get; set; }

    }

    public class Usuario
    {
        public string usuario = "administrador";
        public string password = "administrador.1234";
    }
    class Token
    {
        public int token = new Random().Next(100000, 200000);
    }
}

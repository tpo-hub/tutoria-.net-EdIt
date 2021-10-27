using _2_proyecto_educacionIt.utilidades;

namespace _2_proyecto_educacionIt
{
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
            var ui = new helpersUI();
            
            if(intentos != 3)
            {
                return true; 
            }
            System.Console.WriteLine(ui.bloqueo());
            return false;
        }
    }
}
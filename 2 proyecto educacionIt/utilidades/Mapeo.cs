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
            
            if(intentos != 3)
            {
                return true; 
            }
  
            return false;
        }
    }
}
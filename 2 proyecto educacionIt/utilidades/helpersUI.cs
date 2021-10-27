namespace _2_proyecto_educacionIt.utilidades
{
    public class helpersUI
    {
        public string errorCredenciales()
        {
            return $"\n Error de credenciales... desea volver a intentar? (S/N)";
        }

        public string credencialesCorrectas()
        {
            return $"\nCredenciales correctas, bienvenido a su Online Backing\n";
        }

        public string bienvenida()
        {
            return $"\nBienvenido a Online Banking, por favor ingrese las credenciales solicitadas\n";
        }

        public string despedida()
        {
            return "Gracias por utilizar Online Backing";
        }

        public string claveToken(Token clave)
        {
            return $"\n\tClave Token Generada Automaticamente: {clave.token}\n";
        }

        public string Ingresos(string tipoIngreso)
        {
            return $"Por favor, ingrese su {tipoIngreso}:   ";
        }
    }
}
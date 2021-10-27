using System;

namespace _2_proyecto_educacionIt
{
    public class Token
    {
        public int token = new setToken().token();

    }
    public class setToken
    {
        public int token()
        {
            return new GeneradorToken().getToken(); 
        }
    }  
}
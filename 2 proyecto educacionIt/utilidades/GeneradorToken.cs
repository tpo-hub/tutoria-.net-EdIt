using System;
using System.Collections.Generic;

namespace _2_proyecto_educacionIt
{
    public class GeneradorToken
    {
        public int getToken()
        {
            var TokenList = new List<int>();
            TokenList.Add(1);
            var boolean = true;
            do
            {
                var Nuevotoken = generador();
                var existe = Array.Exists(TokenList.ToArray(), x => x == Nuevotoken);
                if(!existe)
                {
                    TokenList.Add(Nuevotoken);
                    break;
                }

            }
            while(boolean);
            return TokenList[TokenList.Count - 1]; 
        }

        public int generador()
        {
           return new Random().Next(100000, 200000);
        }
    }
}
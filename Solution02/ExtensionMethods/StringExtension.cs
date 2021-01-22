using System;

namespace ExtensionMethods
{
    public static class StringExtension
    {
        public static string FirstToUpper(this String str){
            string First = str.Substring(0,1);
            
            string Restante = str.Substring(1);
            return First.ToUpper() + Restante;
        }
        
    }
}
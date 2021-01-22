using System.IO;
using Newtonsoft.Json;
using Newtonsoft;
using System;

namespace _03_Generics
{
    public class Serializador 
    {
        public static void Serializar (object obj)
        {     
            StreamWriter sw = new StreamWriter(@"C:\Users\AAIO\My Private Documents\Udemy\CursoCSharp_Avancado_Serializacao\Serializar-Deserializar\03_" + obj.GetType().Name + ".txt");
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
              
            sw.Write(json);

            sw.Close();
        }

        public static T Deserializar<T>()
        {
            StreamReader sr = new StreamReader(@"C:\Users\AAIO\My Private Documents\Udemy\CursoCSharp_Avancado_Serializacao\Serializar-Deserializar\03_" + typeof(T).Name + ".txt");
            string conteudo = sr.ReadToEnd();

            var filename = conteudo;

            T obj = JsonConvert.DeserializeObject<T>(conteudo);

            return obj;
        
        }

    }
}
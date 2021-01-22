using System;

namespace VarDinamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object t1 = "";
            object t2 = 123456;

            var v1 = "";
            var v2 = 123456;

            dynamic d1 = new Usuario{Nome="Maria"};

            Console.WriteLine(d1.Nome);
           //Console.WriteLine(d1.Senha); erro


        }
    }
public class Usuario{
    public string Nome {get;set;}
}


}




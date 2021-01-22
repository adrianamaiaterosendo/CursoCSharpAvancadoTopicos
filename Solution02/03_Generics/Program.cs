using System;
using _03_Generics.Modelo;


namespace _03_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Carro carro = new Carro(){Marca="Fiat", Modelo="Uno"};
            // Casa casa = new Casa(){Cidade="Brasilia", Endereco="QSQ 400"};
            // Usuario usuario = new Usuario(){Nome="Maria", Email="maria@teste.com.br", CPF= "123.545.695"};

            // Serializador.Serializar(carro);
            // Serializador.Serializar(casa);
            // Serializador.Serializar(usuario);

            Carro carro2 = Serializador.Deserializar<Carro>();
            Casa casa2 = Serializador.Deserializar<Casa>();
            Usuario usuario2 = Serializador.Deserializar<Usuario>();


            Console.WriteLine("Carro 2 " + carro2.Marca);
            Console.WriteLine("Casa 2 " + casa2.Cidade);
            Console.WriteLine("Usuario 2 " + usuario2.Nome);
        }
    }
}

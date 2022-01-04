using System;
using ExemploPOO.Models;

namespace ExemploPOO {
    class Program {
        static void Main(string[] args) 
        {
            Aluno p1 = new Aluno();
            p1.Nome = "Bob";
            p1.Idade = 20;
            p1.Documento = "123456";
            p1.Nota = 10;
            p1.Apresentar();












        //   // Valores validos
        //   Retangulo r = new Retangulo();
        //   r.Definirmedidas(30, 30);
        //   System.Console.WriteLine($"Área: {r.ObterArea()}");


        //   //Valores invalidos
        //   Retangulo r2 = new Retangulo();
        //   r2.Definirmedidas(0,0);
        //   System.Console.WriteLine($"Área: {r2.ObterArea()}");

            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();
        }
    }
}

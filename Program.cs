using Exemplos.Models;
using System.Globalization;



string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

foreach(string linha in linhas){

    Console.WriteLine(linha);
}






// Pessoa p1 = new Pessoa("Fulano", "de Tal");

// Pessoa p2 = new Pessoa("Beltrano", "da Silva");

// Curso cursoDeCsharp = new Curso();
// cursoDeCsharp.Nome = "Curso de CShrap";
// cursoDeCsharp.Alunos = new List<Pessoa>();

// cursoDeCsharp.Adicionaraluno(p1);
// cursoDeCsharp.Adicionaraluno(p2);
// cursoDeCsharp.ListarAlunos();


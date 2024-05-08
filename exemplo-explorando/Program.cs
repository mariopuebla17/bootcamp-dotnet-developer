using exemplo_explorando.Models;
using System.Globalization;

DateTime data = DateTime.Now;

Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));





// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 82.40M;

// Console.WriteLine($"{valorMonetario:C}");

// Console.WriteLine(valorMonetario.ToString("C",CultureInfo.CreateSpecificCulture("pt-BR")));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));




// string numero1 = "10";
// string numero2 = "20";
// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);





// Pessoa p1 = new Pessoa();
// p1.Nome = "Mario";
// p1.Sobrenome = "Puebla";
// p1.Idade = 30;
// p1.Apresentar();

// Pessoa p1 = new Pessoa
//     (
//         nome: "Mario", 
//         sobrenome: "Puebla"
//     );

// Pessoa p2 = new Pessoa
//     (
//         nome: "Antônio", 
//         sobrenome: "Oliveira"
//     );

// Curso cursoDeIngles = new()
//     {
//         Nome = "Inglês",
//         Alunos = []
//     };

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();
using exemplo_explorando.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Mario";
// p1.Sobrenome = "Puebla";
// p1.Idade = 30;
// p1.Apresentar();

Pessoa p1 = new Pessoa
    (
        nome: "Mario", 
        sobrenome: "Puebla"
    );

Pessoa p2 = new Pessoa
    (
        nome: "Antônio", 
        sobrenome: "Oliveira"
    );

Curso cursoDeIngles = new()
    {
        Nome = "Inglês",
        Alunos = []
    };

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
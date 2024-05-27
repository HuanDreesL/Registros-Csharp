using System.ComponentModel.DataAnnotations;

AlunoNota[] alunos = new AlunoNota[3];

for (int i = 0; i < alunos.Length; i++)
{
    Console.WriteLine("Digite o código do aluno: ");
    alunos[i].Codigo = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a 1° nota do aluno: ");
    alunos[i].Nota1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite a 2° nota do aluno: ");
    alunos[i].Nota2 = float.Parse(Console.ReadLine());
}

float CalcularMediaAluno(AlunoNota alunoNota)
{
    return (alunoNota.Nota1 + alunoNota.Nota2) / 2;
}

foreach (AlunoNota aluno in alunos)
{
    float media = CalcularMediaAluno(aluno);
    if(media >= 7)
    {
        Console.WriteLine($"O aluno {aluno.Codigo} foi aprovado!");
    }
    else
    {
        Console.WriteLine($"O aluno {aluno.Codigo} foi reprovado!");
        Console.WriteLine($"Notas: {aluno.Nota1:F1} e {aluno.Nota2:F1}");
        Console.WriteLine($"Média: {media:F1}\n");
    }
}

struct AlunoNota
{
    public int Codigo;
    public float Nota1;
    public float Nota2;
}

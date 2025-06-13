﻿int quantidadeAlimentos, picaPau, raposa, round, restante;

Console.Clear();
Console.WriteLine("--- Esperto Contra Sabido ---");
Console.Write("Quantos alimentos serão distribuídos? ");

quantidadeAlimentos = int.Parse(Console.ReadLine());
picaPau = 0;
raposa = 0;
round = 1;
restante = quantidadeAlimentos;
 
 
while (quantidadeAlimentos > 0)
{
  if (quantidadeAlimentos > 0)
  {
    int picaPauAlimentos = Math.Min(1, restante);
    Console.Write($"{picaPauAlimentos} para você. ");
    picaPau += picaPauAlimentos;
    restante -= picaPauAlimentos;
  }


  if (restante > 0)
  {
    Console.Write("1, ");
    for (int i = 0; i <= round && quantidadeAlimentos > 0; i++)

    {
      Console.Write(i + (i < round ? ", " : ""));
      quantidadeAlimentos--;
      raposa = +restante;
    }

    Console.WriteLine(" para mim.");
  }


  round++;
}


Console.WriteLine();

Console.WriteLine($"Pica-pau recebeu {picaPau} alimento(s).");
Console.WriteLine($"Raposinha recebeu {raposa} alimento(s).");
    
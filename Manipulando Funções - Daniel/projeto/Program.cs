﻿using System;

class Program
{
  static void Main()
  {
    // Solicita o nome do usuário, quilômetros percorridos por dia, 
    // Horas de uso de eletrônicos por dia e o número de refeições com carne:
    string nome = Console.ReadLine();
    double quilometrosPorDia = double.Parse(Console.ReadLine());
    int horasDeEletronicos = int.Parse(Console.ReadLine());
    int refeicoesComCarne = int.Parse(Console.ReadLine());

    // Chama o método para calcular a pegada de carbono
    double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);

    // TODO: Exiba o resultado para o usuário:
    Console.WriteLine();

    // Aguarda a entrada do usuário antes de encerrar o programa:
    Console.ReadLine();
  }

  // TODO: Crie um método/função para calcular a pegada de carbono com base nos parâmetros fornecidos:


}
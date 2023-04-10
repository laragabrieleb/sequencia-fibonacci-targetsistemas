using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

Console.WriteLine("Informe um número: ");

int numeroInserido = Convert.ToInt32(Console.ReadLine());

List<int> sequencia = new()
{
    0,
    1
};

while (numeroInserido > sequencia.Last())
{
    //pegando a posição do penultimo
    int indexPenultimo = sequencia.Count - 2;
    //somando o valor do ultimo e penultimo
    int proximoItem = sequencia.Last() + sequencia[indexPenultimo];

    //adicionar na lista a soma do ultimo e do penultimo numero
    sequencia.Add(proximoItem);
}

bool sequenciaContemNumeroInserido = sequencia.Any(x => x == numeroInserido);

if (sequenciaContemNumeroInserido)
    Console.WriteLine("O número inserido pertence à sequência de Fibonacci!");
else
    Console.WriteLine("O número inserido não existe na sequência de Fibonacci!");

Console.WriteLine("Sequência de Fibonacci: ");

foreach (var item in sequencia)
{
    Console.WriteLine(item);
}

Console.ReadLine();
using System;

int tamanhoArr = int.Parse(Console.ReadLine());
string[] numeroArr = Console.ReadLine().Split(' ');

int multiplo2 = 0;
int multiplo3 = 0;
int multiplo4 = 0;
int multiplo5 = 0;

for (int iContador = 0; iContador < tamanhoArr; iContador++)
{
    if ((int.Parse(numeroArr[iContador]) %  2) == 0) {multiplo2++;}
    if ((int.Parse(numeroArr[iContador]) %  3) == 0) {multiplo3++;}
    if ((int.Parse(numeroArr[iContador]) %  4) == 0) {multiplo4++;}
    if ((int.Parse(numeroArr[iContador]) %  5) == 0) {multiplo5++;}
}

Console.WriteLine($"{multiplo2} Multiplo(s) de 2");
Console.WriteLine($"{multiplo3} Multiplo(s) de 3");
Console.WriteLine($"{multiplo4} Multiplo(s) de 4");
Console.WriteLine($"{multiplo5} Multiplo(s) de 5");

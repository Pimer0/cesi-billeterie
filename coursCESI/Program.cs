// See https://aka.ms/new-console-template for more information

using coursCESI.Classes;

Salarie salarie1 = new Salarie("Jean", 2000);
Salarie salarie2 = new Salarie("Paul", 3000);
Salarie salarie3 = new Salarie("Jacques", 4000);

Console.WriteLine(salarie1.AfficherSalaire());
Console.WriteLine(salarie2.AfficherSalaire());
Console.WriteLine(salarie3.AfficherSalaire());
Console.WriteLine(Salarie.AfficherNombreDeSalarie());
Console.WriteLine(Salarie.AfficherSalaireTotal());
// See https://aka.ms/new-console-template for more information

using DemoIntrface.Classes;

Console.WriteLine("Programme de création de formes");
IHM ihm = new IHM();
ihm.AfficherMenu();
ihm.AfficherChoix();
while (ihm.choix != 4)
{
    switch (ihm.choix)
    {
        case 1:
            ihm.AfficherRectangle();
            break;
        case 2:
            ihm.AfficherTriangle();
            break;
        case 3:
            ihm.AfficherCarre();
            break;
        default:
            Console.WriteLine("Choix incorrect");
            break;
    }
    ihm.AfficherMenu();
    ihm.AfficherChoix();
}
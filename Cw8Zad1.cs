using System;

public class Program
{
    public static void Main()
    {
        DniTygodnia dzien = DniTygodnia.Poniedzialek;
        EtapyPrania etap = EtapyPrania.Piorace;
        Posilki posilek = Posilki.Sniadanie;
        BierekSzachowy bierka = BierekSzachowy.Krol;

        Console.WriteLine("Dzień tygodnia: " + dzien);
        Console.WriteLine("Etap prania: " + etap);
        Console.WriteLine("Posiłek: " + posilek);
        Console.WriteLine("Bierka szachowa: " + bierka);
    }

    public enum DniTygodnia
    {
        Poniedzialek,
        Wtorek,
        Sroda,
        Czwartek,
        Piatek,
        Sobota,
        Niedziela
    }

    public enum EtapyPrania
    {
        Piorace,
        Plukanie, 
        Suszenie
    }

    public enum Posilki
    {
        Sniadanie,
        DrugieSniadanie,
        Obiad,
        Podwieczorek,
        Kolacja
    }

    public enum BierekSzachowy
    {
        Krol,
        Hetman,
        Wieza,
        Goniec,
        Skoczek,
        Pionek
    }
}

namespace Barkoba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int gn = rnd.Next(1, 1000);
            bool b = true;
            int tips = 0;

            Console.WriteLine("Üdvözöllek a számkitalálós játékban!");
            Console.WriteLine("Tippelj egy számra:");


            do
            {
                int yg;
//ellenőrizzük, hogy számot adott-e meg a felhasználó

                while (!int.TryParse(Console.ReadLine(), out yg))
                {
                    Console.WriteLine("Ez nem szám volt");
                }
//if-else-if-else ág bevezetése
                tips++;

                if (yg < gn)
                {
                    Console.WriteLine("Sajnos nagyobb számra gondoltam!");
                    Console.WriteLine("Az új tipped:");
                    Console.WriteLine();
                }
                else if (yg > gn)
                {
                    Console.WriteLine("Sajnos kisebb számra gondoltam!");
                    Console.WriteLine("Az új tipped:");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Gratulálok, nyertél!");
                    Console.WriteLine();
                    Console.WriteLine("A tippeid száma: {0}", tips);
                    Console.WriteLine();
                    Console.WriteLine("Köszönjük, hogy játszottál, várunk máskor is!");
                    b = false;
                }
            }
            while (b);
        }
    }
}

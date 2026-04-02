namespace TpTestsCalculatrice.App;

class Program
{
    static void Main(string[] args)
    {
        Calculatrice calc = new Calculatrice();

        Console.WriteLine(calc.Addition(2, 3));
        Console.WriteLine(calc.Division(10, 2));

        // testez directement dans le main n'est pas 100% éfficace car il n'est pas facile de vérifier les résultats et de gérer les erreurs
    }
}

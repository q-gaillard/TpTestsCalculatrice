using Microsoft.VisualStudio.TestTools.UnitTesting;
using TpTestsCalculatrice.App;
namespace TpTestsCalculatrice.Tests;
[TestClass]
public class CalculatriceTests
{
    [TestMethod]
    public void Addition_Retourne5_Si2Plus3()
    {
        Calculatrice calc = new Calculatrice();
        int resultat = calc.Addition(2, 3);
        Assert.AreEqual(5, resultat);
        resultat = calc.Soustraction(5, 3);
        Assert.AreEqual(2, resultat);
        resultat = calc.Multiplication(4, 3);
        Assert.AreEqual(12, resultat);
        double resultatDivision = calc.Division(10, 2);
        Assert.AreEqual(5, resultatDivision);
    }
}
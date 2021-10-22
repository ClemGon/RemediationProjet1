using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemediationProjet1;
using RemediationProjet1.MyAbstractFactory.AbastractWithCorrectInterface;
using RemediationProjet1.Scoped;
using RemediationProjet1.Transient;
using System.Collections.Generic;

namespace TestRemediationProjet1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var singleton1 = Singleton.GetInstance();
            
            var singleton2 = Singleton.GetInstance();

            Assert.AreEqual(singleton1, singleton2);
        }

        [TestMethod]
        public void AbstractFactory()
        {
            List<string> carres = Launch(new ConcreteFactoryCarre());
            List<string> rondes = Launch(new ConcreteFactoryRonde());

            Assert.IsTrue(carres.Contains("Je suis une terrasse carré"));
            Assert.IsTrue(carres.Contains("Récupération d'un balcon =====> (Je suis un balcon carré)"));

            Assert.IsFalse(carres.Contains("Je suis une terrasse ronde"));
            Assert.IsFalse(carres.Contains("Récupération d'un balcon =====> (Je suis un balcon ronde)"));

            Assert.IsTrue(rondes.Contains("Je suis une terrasse ronde"));
            Assert.IsTrue(rondes.Contains("Récupération d'un balcon =====> (Je suis un balcon rond)"));

            Assert.IsFalse(rondes.Contains("Je suis une terrasse carré"));
            Assert.IsFalse(rondes.Contains("Récupération d'un balcon =====> (Je suis un balcon carré)"));
        }

        public List<string> Launch(InterfaceFactory factory)
        {
            var Terrasse = factory.CreateTerrasse();
            var Balcon = factory.CreateBalcon();

            // Pas de type de retour.

            List<string> liste = new List<string>();
            
            string terrasse = Terrasse.FunctionTerrasse();
            liste.Add(terrasse);
            
            string balcon = Terrasse.AutreFunctionTerrasse(Balcon);
            liste.Add(balcon);

            return liste;
        }


        [TestMethod]
        public void Scoped()
        {
            Scoped scoped = new Scoped();
            Voiture voiture = new Voiture();
            scoped.Instance(voiture);
            
            var scopp = scoped.GetInstance();

            Scoped scoped1 = new Scoped();
            var scopp1 = scoped1.GetInstance();


            Assert.AreNotEqual(scopp, scopp1);

        }

        [TestMethod]
        public void TestTransient()
        {
            var transient = Transient.GetInstance();
            var transient1 = Transient.GetInstance();
            Assert.AreNotEqual(transient1, transient);
        }


    }
}

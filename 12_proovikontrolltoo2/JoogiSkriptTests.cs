using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine.TestTools;

public class JoogiSkriptTests
{
    [Test]
    public void TestJoogipudeliJook()
    {
        Joogipudel joogipudel = new Joogipudel(100, "Klaas", 100, 20, "Fanta", "Fanta", 1.5f, 0.9f);
        Assert.AreEqual("Fanta", joogipudel.nimetus);
        Assert.AreEqual(1.5f, joogipudel.lHind);
        Assert.AreEqual(0.9f, joogipudel.tihedus);
    }

    [Test]
    public void TestJoogipudeliSisaldabJooki()
    {
        Joogipudel joogipudel = new Joogipudel(100, "Klaas", 100, 20, "Fanta", "Fanta", 1.5f, 0.9f);
        Assert.AreEqual("Fanta", joogipudel.sisaltabJooki);
    }

    [Test]
    public void TestJoogipudeliOmahind()
    {
        Joogipudel joogipudel = new Joogipudel(100, "Klaas", 100, 20, "Fanta", "Fanta", 1.5f, 0.9f);
        Assert.AreEqual(1.5f, joogipudel.lHind);
    }

    [Test]
    public void TestJoogipudeliMaht()
    {
        Joogipudel joogipudel = new Joogipudel(100, "Klaas", 100, 20, "Fanta", "Fanta", 1.5f, 0.9f);
        Assert.AreEqual(110, joogipudel.maht);
    }

    [UnityTest]
    public IEnumerator JoogiSkriptTestsWithEnumeratorPasses()
    {
        // Siia võite lisada mõne Unity testi, kui soovite.
        // Kasutage yield, et jätta vahele üks kaader.
        yield return null;
    }
}

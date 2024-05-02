using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Jook
{
    public string nimetus;
    public float lHind; //Omahind
    public float tihedus; //Ehk grammi liitri kohta

    public Jook(string nimetus, float lHind, float tihedus)
    {
        this.nimetus = nimetus;
        this.lHind = lHind;
        this.tihedus = tihedus;
    }
}

public class Joogipudel : Jook
{
    public float maht;
    public string pudelityyp;
    public float mass;
    public float taaraMaksumus;
    public int jarjekorraNumber;

    public Joogipudel(float maht, string pudelityyp, float mass, float taaraMaksumus, int jarjekorraNumber, string nimetus, float lHind, float tihedus)
        : base(nimetus, lHind, tihedus)
    {
        this.maht = maht;
        this.pudelityyp = pudelityyp;
        this.mass = mass;
        this.taaraMaksumus = taaraMaksumus;
        this.jarjekorraNumber = jarjekorraNumber;
    }
}
public class Joogivaat : Joogipudel
{
    public float ruumala;
    public float kogusL;

    public Joogivaat(float maht, string pudelityyp, float mass, float taaraMaksumus, int jarjekorraNumber, string nimetus, float lHind, float tihedus, float ruumala, float kogusL)
        : base(maht, pudelityyp, mass, taaraMaksumus, jarjekorraNumber, nimetus, lHind, tihedus)
    {
        this.ruumala = ruumala;
        this.kogusL = kogusL;
    }
}


public class JoogiSkript : MonoBehaviour
{
    //public Joogipudel[] joogipudel;

    void Start()
    {
        //Esimene ÜL
        //                                   Maht Pudeltüüp Mass    TMaks JN  Nimetus lHind tihedus/erikaal   
        Joogipudel joogipudel = new Joogipudel(0.5f, "Klaas", 0.35f, 0.1f, 1, null, 0.38f, 1.02f); // Joogipudel: Maht, Pudelitüüp, Mass, Taaramaksumus, Mis jook on, Jook: nimetus, lHind, tihedus/erikaal
        string nimetus = joogipudel.nimetus;
        if (nimetus != null)
        {
            print("Joogipudeli sees jook on " + joogipudel.nimetus + " ja selle maht on " + joogipudel.maht);
            print("Joogi omahind on " + joogipudel.lHind);
        }
        //Teine ÜL
        Joogivaat jaoogivaat = new Joogivaat(0.5f, "Klaas", 0.35f, 0.1f, 1, null, 0.38f, 1.02f, 10, 1.3f);//Lisaks ruumala ja kogus
        Joogipudel joogipudel1 = new Joogipudel(0.5f, "Klaas", 0.35f, 0.1f, 1, null, 0.38f, 1.02f);
        Joogipudel joogipudel2 = new Joogipudel(0.5f, "Klaas", 0.35f, 0.1f, 2, null, 0.38f, 1.02f);
        Joogipudel joogipudel3 = new Joogipudel(0.5f, "Klaas", 0.35f, 0.1f, 3, null, 0.38f, 1.02f);

        if (jaoogivaat.kogusL >= joogipudel.maht)
        {
            
        }
    }
}
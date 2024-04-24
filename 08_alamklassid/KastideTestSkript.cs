using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kast
{
    protected float taraMass;
    protected float sisuMass;
    protected string nimetus;
    protected float hind;
    protected string materjal;

    public Kast(float taraMass, float sisuMass, string nimetus, float hind, string materjal)
    {
        this.taraMass = taraMass;
        this.sisuMass = sisuMass;
        this.nimetus = nimetus;
        this.hind = hind;
        this.materjal = materjal;
    }

    public string Materjal
    {
        get { return materjal; }
    }
}

public class RiiuliKast : Kast
{
    private int riiuliNumber;

    public RiiuliKast(float taraMass, float sisuMass, string nimetus, float hind, string materjal, int riiuliNumber)
        : base(taraMass, sisuMass, nimetus, hind, materjal) //Ülemklass
    {
        this.riiuliNumber = riiuliNumber;
    }
}

public class KastideTestSkript : MonoBehaviour
{
    void Start()
    {
        RiiuliKast riiuliKast = new RiiuliKast(2f, 5f, "Raamatukast", 20f, "Puit", 3);
        string materjal = riiuliKast.Materjal;
        switch (materjal)
        {
            case "Puit":
                Debug.Log("See kast on valmistatud puidust.");
                break;
            case "Metall":
                Debug.Log("See kast on valmistatud metallist.");
                break;
            default:
                Debug.Log("Kasti materjali ei tuvastatud.");
                break;
        }
    }
}

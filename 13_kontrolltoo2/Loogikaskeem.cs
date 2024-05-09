using UnityEngine;
using UnityEngine.UI;
using System;
using JetBrains.Annotations;
using System.Reflection;
using UnityEngine.Windows;

[System.Serializable]
public class LoogilineOR
{
    public int kanal;
    public int kanal2;
    public bool seisund;
    public bool seisund2;

    public LoogilineOR(int kanal, int kanal2, bool seisund, bool seisund2)
    {
        this.kanal = kanal;
        this.kanal2 = kanal2;
        this.seisund = seisund;
        this.seisund2 = seisund2;
    }

    public bool OR()
    {
        return (seisund || seisund2);
    }
}

public class LoogilineNOT
{
    public int kanal;
    public bool seisund;

    public LoogilineNOT(int kanal, bool seisund)
    {
        this.kanal = kanal;
        this.seisund = seisund;
    }

    public bool Not()
    {
        return (!seisund);
    }
}

public class LoogilineAND
{
    public int kanal;
    public int kanal2;
    public bool seisund;
    public bool seisund2;

    public LoogilineAND(int kanal, int kanal2, bool seisund, bool seisund2)
    {
        this.kanal = kanal;
        this.kanal2 = kanal2;
        this.seisund = seisund;
        this.seisund2 = seisund2;
    }

    public bool AND()
    {
        return (seisund && seisund2);
    }
}

public class Loogikaskeem : MonoBehaviour
{
    public Image input1Image;
    public Image input2Image;
    public Image input3Image;
    public Image input4Image;

    public Image Not1Image;
    public Image Not2Image;
    public Image Or1Image;
    public Image And1Image;
    public Image And2Image;

    public Image EndImage;

    private bool input1;
    private bool input2;
    private bool input3;
    private bool input4;

    void Start()
    {  //Test1
        LoogilineOR loogilineOR = new LoogilineOR(1, 2, false, true);
        bool tulemus = loogilineOR.OR();
        Debug.Log("Tulemus on " + tulemus);
        //Test2
        LoogilineOR loogilineOR2 = new LoogilineOR(1, 2, true, true);
        bool tulemus2 = loogilineOR2.OR();
        Debug.Log("Tulemus2 on " + tulemus2);
        //Test3
        LoogilineOR loogilineOR3 = new LoogilineOR(1, 2, false, false);
        bool tulemus3 = loogilineOR3.OR();
        Debug.Log("Tulemus3 on " + tulemus3);

    }
    public void test1()
    {
        input1 = true;
        input2 = false;
        input3 = false;
        input4 = true;

        UpdateInputImages();


        LoogilineNOT loogilineNOT = new LoogilineNOT(1, input2);
        bool NotOutput1 = loogilineNOT.Not();
        Not1Image.color = UpdateImage(NotOutput1);


        LoogilineOR loogilineOR = new LoogilineOR(1, 2, NotOutput1, input3);
        bool OrOutput1 = loogilineOR.OR();
        Or1Image.color = UpdateImage(OrOutput1);

        LoogilineAND loogilineAND = new LoogilineAND(1, 2, input1, OrOutput1);
        bool AndOutput1 = loogilineAND.AND();
        And1Image.color = UpdateImage(AndOutput1);

        LoogilineNOT loogilineNOT2 = new LoogilineNOT(1, AndOutput1);
        bool NotOutput2 = loogilineNOT2.Not();
        Not2Image.color = UpdateImage(NotOutput2);

        LoogilineAND loogilineAND2 = new LoogilineAND(1, 2, NotOutput2, input4);
        bool AndOutput2 = loogilineAND2.AND();
        And2Image.color = UpdateImage(AndOutput2);
        EndImage.color = UpdateImage(AndOutput2);


    }

    public void test2()
    {
        input1 = false;
        input2 = false;
        input3 = true;
        input4 = true;

        UpdateInputImages();


        LoogilineNOT loogilineNOT = new LoogilineNOT(1, input2);
        bool NotOutput1 = loogilineNOT.Not();
        Not1Image.color = UpdateImage(NotOutput1);


        LoogilineOR loogilineOR = new LoogilineOR(1, 2, NotOutput1, input3);
        bool OrOutput1 = loogilineOR.OR();
        Or1Image.color = UpdateImage(OrOutput1);

        LoogilineAND loogilineAND = new LoogilineAND(1, 2, input1, OrOutput1);
        bool AndOutput1 = loogilineAND.AND();
        And1Image.color = UpdateImage(AndOutput1);

        LoogilineNOT loogilineNOT2 = new LoogilineNOT(1, AndOutput1);
        bool NotOutput2 = loogilineNOT2.Not();
        Not2Image.color = UpdateImage(NotOutput2);

        LoogilineAND loogilineAND2 = new LoogilineAND(1, 2, NotOutput2, input4);
        bool AndOutput2 = loogilineAND2.AND();
        And2Image.color = UpdateImage(AndOutput2);
        EndImage.color = UpdateImage(AndOutput2);
    }

    public void test3()
    {
        input1 = true;
        input2 = false;
        input3 = false;
        input4 = false;

        UpdateInputImages();


        LoogilineNOT loogilineNOT = new LoogilineNOT(1, input2);
        bool NotOutput1 = loogilineNOT.Not();
        Not1Image.color = UpdateImage(NotOutput1);


        LoogilineOR loogilineOR = new LoogilineOR(1, 2, NotOutput1, input3);
        bool OrOutput1 = loogilineOR.OR();
        Or1Image.color = UpdateImage(OrOutput1);

        LoogilineAND loogilineAND = new LoogilineAND(1, 2, input1, OrOutput1);
        bool AndOutput1 = loogilineAND.AND();
        And1Image.color = UpdateImage(AndOutput1);

        LoogilineNOT loogilineNOT2 = new LoogilineNOT(1, AndOutput1);
        bool NotOutput2 = loogilineNOT2.Not();
        Not2Image.color = UpdateImage(NotOutput2);

        LoogilineAND loogilineAND2 = new LoogilineAND(1, 2, NotOutput2, input4);
        bool AndOutput2 = loogilineAND2.AND();
        And2Image.color = UpdateImage(AndOutput2);
        EndImage.color = UpdateImage(AndOutput2);
    }

    Color UpdateImage(bool state)
    {
        if(state == false)
        {
            return Color.red;
        }else if(state == true)
        {
            return Color.green;
        }
        return Color.red;
    }

    void UpdateInputImages()
    {
        if (input1)
            input1Image.color = Color.green;
        else
            input1Image.color = Color.red;

        if (input2)
            input2Image.color = Color.green;
        else
            input2Image.color = Color.red;

        if (input3)
            input3Image.color = Color.green;
        else
            input3Image.color = Color.red;

        if (input4)
            input4Image.color = Color.green;
        else
            input4Image.color = Color.red;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiger : feline
{
    //variables that are ONLY in tiger
    public string stripes;
    public string solitary;

    //make the tiger subclass of the feline
    public tiger(string carbon, string milk, string babies, string claws, string whiskers, string stripes, string solitary) :
    base(carbon, milk, babies, claws, whiskers)
    {
        this.stripes = stripes;
        this.solitary = solitary;
        this.type = "tiger";
    }

    //update the string using the previous showrecord
    public override string ShowRecord()
    {
        return
            base.ShowRecord() + "Stripes: " + stripes + "\n" + "Solitary:" + solitary + "\n";
    }
}

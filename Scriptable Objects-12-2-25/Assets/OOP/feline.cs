using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feline : mammal
{
    //variables that are ONLY in feline
    public string claws;
    public string whiskers;

    //make the feline class a subclass of mammal
    public feline(string carbon, string milk, string babies, string claws, string whiskers) : 
        base(carbon, milk, babies)
        {
            this.claws = claws;
            this.whiskers = whiskers;
            this.type = "feline";
        }

        //update the new info in our showrecord by adding the previous function
        public override string ShowRecord()
        {
            return
                base.ShowRecord() + "Claws: " + claws + "\n" + "Whiskers: " + whiskers + "\n";
        }
    
}

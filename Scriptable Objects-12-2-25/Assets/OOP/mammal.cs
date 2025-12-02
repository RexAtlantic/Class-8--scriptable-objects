using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mammal : organism
{
   //variables that are ONLY MAMMALS
   public string milk;
   public string babies;


   //make mammal a subclass of organism
   public mammal(string carbon, string milk, string babies) :
      base(carbon)
      {
        this.milk = milk;
        this.babies = babies;
        this.type = "mammal";
      }
}

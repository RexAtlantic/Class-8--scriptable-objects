using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class organism 
{
   //variables 
   public string carbon;
   public string type;

   //make the class of an organism
   public organism(string carbon)
   {
        this.carbon = carbon;
        type = "organism";
   }

   //show the record of the class we made
   public virtual string ShowRecord()
   {
        return
        "Type: " + type + "\n" + "Carbon" + carbon + "\n";
   }
}

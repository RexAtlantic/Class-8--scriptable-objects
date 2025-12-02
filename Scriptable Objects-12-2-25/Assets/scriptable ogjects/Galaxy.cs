using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Galaxy", menuName = "Scriptable Objects/Galaxy", order = 0)]
public class Galaxy : ScriptableObject
{
    //Variables facts about the Galaxy

    public string Galaxyname = "Name the Galaxy";
    public string Galaxytype = "Describe the Galaxy";

    public Sprite Galaxypic;

    public Galaxy nextgalaxy;
}

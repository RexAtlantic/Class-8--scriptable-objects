using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scriptOBJmanager : MonoBehaviour
{
    //variables

    public Galaxy galaxy;

    public TextMeshProUGUI nametext;
    public TextMeshProUGUI desctext;
    public Image galaxyimage;


    // Start is called before the first frame update
    void Start()
    {
        UpdateGalaxy();
    }


    //make a function that activates the next galaxy
    public void NextGalaxy()
    {
        galaxy = galaxy.nextgalaxy;
        UpdateGalaxy();
    }


    //function to show going from one object to the next object
    public void UpdateGalaxy()
    {
        nametext.text = galaxy.Galaxyname;
        desctext.text = galaxy.Galaxytype;
        galaxyimage.sprite = galaxy.Galaxypic;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class oopmanager : MonoBehaviour
{
    //variables
    public TextMeshProUGUI text;

    public List<organism> organismlist;

    private int recordNum = 0;


    // Start is called before the first frame update
    void Start()
    {
        organismlist = new List<organism>();
        organism first = new organism("it is carbon based");
        organism second = new mammal("it is carbon based", "it produces milk", "it gives live birth");
        organism third = new feline("it is carbon based", "it produces milk", "it gives live birth", "it has claws", "it has whiskers");
        organism fourth = new tiger("it is carbon based", "it produces milk", "it gives live birth", "it has claws", "it has whiskers", "has stripes", "is solitary");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class butt : MonoBehaviour
{
    public Slider Slider; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PrintBUtton()
    {
        print("Button");

    }

    public void Scrollchange()
    {

        print(Slider.value);

    }    

    

    // Update is called once per frame
    void Update()
    {
        
    }
}

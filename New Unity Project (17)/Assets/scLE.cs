using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scLE : MonoBehaviour
{
    float LastDist;
    GameObject Moving;

    // Start is called before the first frame update
    void Start()
    {
       
    }
    void ScaleObject()
    {
        float CurrDist = (Input.touches[0].position - Input.touches[1].position).magnitude;
        if (LastDist != 0)
        {
           Moving.transform.localScale += Vector3.one * (LastDist - CurrDist) * Time.deltaTime * 0.5f;
                 
        }
        LastDist = CurrDist;
        foreach(Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Ended)
            {
                LastDist = 0;
            }

        }
    }





   
    // Update is called once per frame
    void Update()
    {
        if (Input.touches.Length == 2)
        {
            ScaleObject();

        }
    }
}

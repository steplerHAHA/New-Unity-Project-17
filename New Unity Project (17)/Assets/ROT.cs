using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Android;

public class ROT : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        
        {
            if (touch.phase == TouchPhase.Moved)
            {
                transform.Rotate(new Vector3(0, -touch.deltaPosition.x, 0));
            }
        }

    }
}

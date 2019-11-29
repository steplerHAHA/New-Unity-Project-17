using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioffect : MonoBehaviour
{
    [SerializeField] AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Playsound()
    {
        audio.Play();
    }
    // Update is called once per frame
    void Update()
    {
     if (Input.GetButtonDown("Jump"))
        {
            audio.Play();
        }
    }
}

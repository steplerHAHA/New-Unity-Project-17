using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle : MonoBehaviour
{
    [SerializeField] AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void PLaySound()
    {
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfso : MonoBehaviour
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
    public void OnMouseDown()
    {
        audio.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

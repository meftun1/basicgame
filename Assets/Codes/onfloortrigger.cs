using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onfloortrigger : MonoBehaviour
{
    hero karakter;
    void Start()
    {
        karakter = transform.root.gameObject.GetComponent<hero>();
    }

    void Update()
    {
        
    }
    void OnTriggerEnter2D()
    {
        karakter.onFloor = true;
    }
    void OnTriggerStay2D()
    {
        karakter.onFloor = true;
    }
     void OnTriggerExit2D()
    {
        karakter.onFloor = false;
    }

}

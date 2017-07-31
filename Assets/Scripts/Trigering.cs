using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 
public class Trigering : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Object")
        {
            gameObject.tag = "Busy";
        }
    }
}

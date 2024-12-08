using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float jumpFactor = 10f;
    private float oldJump;
    void OnTriggerEnter(Collider other)
    {
        oldJump = other.GetComponent<Jump>().jumpStrength;
        other.GetComponent<Jump>().jumpStrength = 10; 
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = oldJump;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitchDoor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("we good to switch scenes");
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour
{

    [SerializeField] private Animator door = null;

    [SerializeField] private bool openTrigger = false;
    

   private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object Entered the trigger");
        if (other.CompareTag("Player")){

            if (openTrigger)
            {
                Debug.Log("we here");
                door.Play("door open", 0, 0.0f);
                
                
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        openTrigger = false;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Object Exited the trigger");
           if (other.CompareTag("Player")){

            if (!openTrigger)
            {
                door.Play("Door close", 0, 0.0f);
                openTrigger = true;
                
            }
        }
    }
}

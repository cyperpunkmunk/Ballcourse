using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasureTrigger : MonoBehaviour
{

    

    public bool fadeOut = false;
   
    

    void Update()
    {
         
    }


    public void OnTriggerEnter(Collider Player)
    {
        
        fadeOut = true;

        Debug.Log("you found an object");
        
        triggerListenToDelete();

    }

    public void triggerListenToDelete(){
         
        if(fadeOut)
        {
           Destroy(GetComponent<Rigidbody>());
            
        }

    }



  
}

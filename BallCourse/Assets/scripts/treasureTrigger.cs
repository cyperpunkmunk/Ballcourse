using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasureTrigger : MonoBehaviour
{

    

    public bool fadeOut = false;
   
    

    void Update()
    {
        triggerListenToDelete();
    }


    public void OnTriggerEnter(Collider Player)
    {

        Debug.Log("you found an object");
        
        fadeOut = true;

    }

    public void triggerListenToDelete(){
         
        if(fadeOut)
        {
            
            Debug.Log("item gone");
            Destroy(gameObject);
            fadeOut = false;
        }

    }



  
}

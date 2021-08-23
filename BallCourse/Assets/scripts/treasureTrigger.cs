using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasureTrigger : MonoBehaviour
{

    

    public bool fadeOut;
   
    

    public void OnTriggerEnter(Collider Player)
    {
        
        fadeOut = true;

        Debug.Log("you found an object");
        
        triggerListen();

    }

    public void triggerListen(){
         
        if(fadeOut)
        {
           
            Debug.Log("fadeOut");
            fadeOut = false;
        }

    }



  
}

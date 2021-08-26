using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class treasureTrigger : MonoBehaviour
{

    public GameObject gameCount;

    private treasureCollection trCount;



    public bool fadeOut = false;
   
    
    public void Start()
    {
        gameCount.GetComponent<treasureCollection>();

    }


    void Update()
    {
        triggerListenToDelete();
    }


    public void OnTriggerEnter(Collider Player)
    {

        Debug.Log("you found an object");
        
        trCount.treasureCount ++;

        fadeOut = true;

    }

    public void triggerListenToDelete(){
         
        if(fadeOut)
        {
            Debug.Log(trCount.treasureCount);
            Destroy(gameObject);
            fadeOut = false;
        }

    }



  
}

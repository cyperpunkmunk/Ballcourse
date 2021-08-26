using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class treasureTrigger : MonoBehaviour
{
    // Getting the game object gameCount which is the id on our main player that keeps the score
    public GameObject gameCount;

    // this is the name of the script on our object that holds the data we need for our score count
    private treasureCollection trCount;


    
    private bool fadeOut = false;
   
    
    public void Start()
    {
        // where we get the needed component from our other script to be able too use in this script
        // we also had to set it to an object so we could use the naming to access it later to retrive our data from the other code
        trCount = gameCount.GetComponent<treasureCollection>();

    }


    void Update()
    {
        // each frame we listen for the item pickup
        triggerListenToDelete();
    }
        


    public void OnTriggerEnter(Collider Player)
    {

        Debug.Log("you found an object");
        // increment the count
        trCount.treasureCount ++;
        // then set the fade out to true so we dont keep running the code above
        fadeOut = true;

    }

    public void triggerListenToDelete(){
        // when the item is picked up and fadeout is set to true
        if(fadeOut)
        {
            Debug.Log(trCount.treasureCount);
            // destroying the object
            Destroy(gameObject);
            // set it back to false so we dont keep running this code
            fadeOut = false;
        }

    }



  
}

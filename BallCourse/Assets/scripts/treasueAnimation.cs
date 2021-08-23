using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasueAnimation : MonoBehaviour
{
    
   private bool fadeOut, fadeIn;
   public float fadeSpeed;


   //Update is called once per frame
   void Update (){

       if(Input.GetKeyDown(KeyCode.A)){
           fadeOutObject();
       }

       if(fadeOut){
           Color objectColor = this.GetComponent<Renderer>().material.color;
           float fadeAmount = objectColor.a - (fadeSpeed * Time.deletaTime);

           objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
           this.GetComponent<Renderer>().material.color = objectColor;

           if(objectColor.a <=0)
           {
               FadeOut = false;
           }

       }

   }

   public void fadeOutObject(){

       fadeOut = true;

   } 


   public void FadeInObject(){

       fadeIn = true;

   }

   
    
}

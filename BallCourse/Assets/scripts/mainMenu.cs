using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
   public void PlayGame (){
       //Loads the next level by getting the index of the current scene and adding one
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

   public void QuitGame (){
       Application.Quit();
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f; 
    bool gameHasEnded = false;

    //
    
    public GameObject RestarMenuUI;

    //
    public GameObject completeLevelUI;
    //
   
        //
    public void ComepleteLevel()
    {
        Debug.Log("WIN GAME");
        completeLevelUI.SetActive(true);


    }
    public void EndGame()
    {   if(gameHasEnded==false)
        {
            gameHasEnded = true;
            Debug.Log("END GAME");
           
            Invoke("Restart", restartDelay);

        }
    }
     void Restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
       
    }

    

}


using UnityEngine;
using UnityEngine.SceneManagement;
public class Warning : MonoBehaviour
{
    public GameManager gameManager; 
    public void YesButton()
    {
        Debug.Log("Congratulation");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

       
    }
  public  void NoButton()
    {
        //gameManager.EndGame();

        Debug.Log("YOU DIE, PLAY AGAIN");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}

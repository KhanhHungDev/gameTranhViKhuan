
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("QUIT GAME!!");
        Application.Quit();
       
    }
    public void Next()
    {
        Debug.Log("NEXT SCENE!!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

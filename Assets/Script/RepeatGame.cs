using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RepeatGame : MonoBehaviour
{
    public void EndGame()
    {
        StartCoroutine("GameOver");
    }

    private IEnumerable GameOver()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

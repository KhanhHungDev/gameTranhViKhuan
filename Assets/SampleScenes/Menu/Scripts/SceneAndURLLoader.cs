using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAndURLLoader : MonoBehaviour
{
    private PauseMenuController m_PauseMenu;


    private void Awake ()
    {
        m_PauseMenu = GetComponentInChildren <PauseMenuController> ();
    }


    public void SceneLoad(string sceneName)
	{
		//PauseMenu pauseMenu = (PauseMenu)FindObjectOfType(typeof(PauseMenu));
		m_PauseMenu.MenuOff ();
		SceneManager.LoadScene(sceneName);
	}


	public void LoadURL(string url)
	{
		Application.OpenURL(url);
	}
}


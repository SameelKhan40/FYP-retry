using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject settingspanel;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void OpenSettings()
    {
        settingspanel.SetActive(true);
    }
    public void CloseSettings()
    {
        settingspanel.SetActive(false);    
    }
    public void ExitGame()
    {
        Debug.Log("Good Bye~");
        Application.Quit();
    }
}

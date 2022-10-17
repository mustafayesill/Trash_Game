using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene(2);
    }

    public void EducationButton()
    {
        SceneManager.LoadScene(3);

    }

    public void QuitButton()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(1);

    }
    public void SignUpButton()
    {
        SceneManager.LoadScene(0);
    }
    public void LogInButton()
    {
        SceneManager.LoadScene(1);
    }
    public void lvl1_devam()
    {
        SceneManager.LoadScene(3);
    }
    public void lvl2_devam()
    {
        SceneManager.LoadScene(4);
    }
    public void lvl3_devam()
    {
        SceneManager.LoadScene(5);
    }
    public void lvl4_devam()
    {
        SceneManager.LoadScene(6);
    }
    public void lvl5_devam()
    {
        SceneManager.LoadScene(7);
    }
    public void lvl6_devam()
    {
        SceneManager.LoadScene(8);
    }




}

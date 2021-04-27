using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void startGame()
    {

        int temp = Random.Range(1, 5);
        float rndLevel = Probabilities.UniformCDF(1f, 4f, temp);
        if (rndLevel == 0f)
        {
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (rndLevel < 0.34f)
        {
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        else if (rndLevel < 0.67f)
        {
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
        else
        {
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        }
    }

    public void credits()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}

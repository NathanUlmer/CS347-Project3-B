using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void startGame()
    {
        // =========================
        // Here we use a Uniform Distribution from the probabilities class in order to
        // determine what random level comes next. Each level has the same chance of being
        // selected and it keeps track so it wont repeat any you have beaten.

        int temp = Random.Range(1, 5);
        float rndLevel = Probabilities.UniformCDF(1f, 4f, temp);

        // =========================
        if (rndLevel == 0f)
        {
          levelTracker.visitedLevels.Add(1);
          foreach (int x in levelTracker.visitedLevels)
          {
            Debug.Log(x.ToString());

          }
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (rndLevel < 0.34f)
        {
          levelTracker.visitedLevels.Add(2);
          foreach (int x in levelTracker.visitedLevels)
          {
            Debug.Log(x.ToString());

          }
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        else if (rndLevel < 0.67f)
        {
          levelTracker.visitedLevels.Add(3);
          foreach (int x in levelTracker.visitedLevels)
          {
            Debug.Log(x.ToString());

          }
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
        else
        {
          levelTracker.visitedLevels.Add(4);
          foreach (int x in levelTracker.visitedLevels)
          {
            Debug.Log(x.ToString());

          }
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        }
    }
    public void returnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void credits()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}

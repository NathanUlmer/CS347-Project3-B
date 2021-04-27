using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public Vector2 playerInitialPosition;

    private GameObject[] enemies;
    private GameObject player;

    void Awake() {
        if (instance == null)
            instance = this;

        Time.timeScale = 1f;
    }

    void Start() {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        player = GameObject.FindWithTag("Player");
    }

    public void PlayerReachedGoal() {

        // =========================
        // Here we use a Uniform Distribution from the probabilities class in order to
        // determine what random level comes next. Each level has the same chance of being
        // selected and it keeps track so it wont repeat any you have beaten.
        int temp = Random.Range(1, 5);
        float rndLevel = Probabilities.UniformCDF(1f, 4f, temp);
        // =========================


          if (levelTracker.visitedLevels.Count == 4)
          {
            SceneManager.LoadScene(6);
          }
          else if (rndLevel == 0f)
          {
            if (!levelTracker.visitedLevels.Contains(1))
            {
              levelTracker.visitedLevels.Add(1);
              foreach (int x in levelTracker.visitedLevels)
              {
                Debug.Log(x.ToString());

              }

              SceneManager.LoadScene(1);
            }
            else
            {
              PlayerReachedGoal();
            }
          }
          else if (rndLevel < 0.34f)
          {
            if (!levelTracker.visitedLevels.Contains(2))
            {
              levelTracker.visitedLevels.Add(2);
              foreach (int x in levelTracker.visitedLevels)
              {
                Debug.Log(x.ToString());

              }
              SceneManager.LoadScene(2);
            }
            else
            {
              PlayerReachedGoal();
            }          }
          else if (rndLevel < 0.67f)
          {
            if (!levelTracker.visitedLevels.Contains(3))
            {
              levelTracker.visitedLevels.Add(3);
              foreach (int x in levelTracker.visitedLevels)
              {
                Debug.Log(x.ToString());

              }
              SceneManager.LoadScene(3);
            }
            else
            {
              PlayerReachedGoal();
            }
          }
          else
          {
            if (!levelTracker.visitedLevels.Contains(4))
            {
              levelTracker.visitedLevels.Add(4);
              foreach (int x in levelTracker.visitedLevels)
              {
                Debug.Log(x.ToString());

              }
              SceneManager.LoadScene(4);
            }
            else
            {
              PlayerReachedGoal();
            }
          }

    }

    public void PlayerDied() {
        Time.timeScale = 0f;

        StartCoroutine(RestartGame());
    }

    IEnumerator RestartGame() {
        yield return new WaitForSecondsRealtime(2f);

        UnityEngine.SceneManagement.SceneManager.LoadScene(
        UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }


} // class

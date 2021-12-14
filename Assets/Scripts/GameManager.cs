using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject completeLevelUI;
    public float rTime = 2f;
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GameOver");
            Invoke("restart",rTime);
        }
    }
    public void completeLevel()
    {
        Debug.Log("Level Ended");
        completeLevelUI.SetActive(true);
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

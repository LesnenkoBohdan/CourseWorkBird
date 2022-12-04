using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Ф-ція завершення гри після зіштовхування з колоною та землею
    public GameObject gameOverCanvas;
    public void Start()
    {
        //Початок
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        //Кінець
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    //Повтро гри з початку
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}

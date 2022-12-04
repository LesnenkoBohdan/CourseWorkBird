using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFly : MonoBehaviour
{
    public GameManager gameManager;
    //Зміна швидкості твердого 2Д тіла
    public float velocity = 1;
    private Rigidbody2D rb;
    void Start()
    {
        //Отримання команди стрибок на початку гри
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Натискаєм ліву кнопку миші - стрибок
        if (Input.GetMouseButtonDown(0))
        {
            //Швидкість стрибка при натисканні
            rb.velocity = Vector2.up * velocity;
        }
    }
    //Сценарій для завершення гри пташкою
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
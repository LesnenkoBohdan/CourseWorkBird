using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Швидкість генерування колон
    public float speed;


    void Update()
    {
        // Рух камери вліво, відносно пташки(пташка завжди статична, і стоїть на місці, їдуть тільки колони)
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}

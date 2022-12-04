using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    //Коли пташка потрапляє в зону між колоною, + до рахунку
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
    }
}

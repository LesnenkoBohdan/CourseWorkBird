
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    //Підрахунок після кожної колони
    public static int score = 0;
    private void Start()
    {
        score = 0;
    }


    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}

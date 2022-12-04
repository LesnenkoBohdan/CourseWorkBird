using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Час перед новим спауном колони
    public float maxTime = 1;
    //Час який минає
    private float timer = 0;
    //Посилання на ігровий об'єкт
    public GameObject pipe;
    public float height;
    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    void Update()
    {
        if(timer > maxTime)
        {
            //Почасово створення новго потоку колон
            GameObject newpipe = Instantiate(pipe);
            //Рандомний спун по висоті колон
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            //Видалення колони через деякий час, після того, як вона з поля зору
            Destroy(newpipe, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}

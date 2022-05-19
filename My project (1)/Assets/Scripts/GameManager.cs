using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshPro timerText;
    private Timer timer;


    public GameObject aliensPrefab;
    public Transform[] alienSpawnPoints;

    void Start()
    {
        timer = GetComponent<Timer>();

        Spawnaliens();
    }
    
        

    // Update is called once per frame
    void Update()
    {
        if (timer.timerIsRunning)
        {
            timerText.text = timer.GetTimeForDisplay();

        }
    }






    void Spawnaliens()

    {
        int index = Random.Range(0, alienSpawnPoints.Length);
        Vector3 spawnPos = alienSpawnPoints[index].position;


        GameObject aliens = Instantiate(aliensPrefab, Vector3.zero, Quaternion.identity);

        aliens.GetComponent<AlienMovement>().speed = Random.Range(3.0f, 6.0f);

    }
         

    
}

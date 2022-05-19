using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMovement : MonoBehaviour
{


    public float speed = 5;


    void Update()
    {

        float xValue = speed * Time.deltaTime;
        transform.Translate(xValue, 0, 0);





    }













}

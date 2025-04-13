using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bug : MonoBehaviour
{
    public float speed = 1.5f;// the speed of the bug's movement
    private Vector2 direction;


   
    void Start()
    {
        direction = Random.insideUnitCircle; //randome the movement direction of bugs

       
       

    }

    void Update() // make bugs moving
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }


}


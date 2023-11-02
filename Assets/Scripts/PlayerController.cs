using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed;

    private void Start()
    {
        speed = 20;
    }

    void Update()
    {
        MoveForward();    
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward*this.speed*Time.deltaTime);
    }

}

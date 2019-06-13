﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement_controller : MonoBehaviour
{
    public int speed;
    public bool canMove;
    void Start()
    {
        Cursor.visible = false;
        speed = 1;
        canMove = true;
    }
    void Update()
    {
        faceMouse();
        move();
    }
    void faceMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 pos = ray.origin + (ray.direction);

        transform.LookAt(new Vector3(pos.x, transform.position.y, pos.z));
    }
    void move()
    {
        if (canMove)
        {
            if (Input.GetKey(KeyCode.W))
            {
                //RaycastHit hit;
                //if (Physics.Raycast(transform.position, transform.position + new Vector3(0, 0, 5), out hit))
                //{
                //    Debug.DrawLine(transform.position, transform.position + new Vector3(0, 0, 5));
                //    Debug.Log("distanza alto: " + hit.distance);
                //    if (hit.distance > 8)

                //}
                transform.position += new Vector3(0, 0, speed);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.position -= new Vector3(0, 0, speed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= new Vector3(speed, 0, 0);
            }
        }
    }
}

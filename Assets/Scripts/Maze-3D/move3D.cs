using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class move3D : MonoBehaviour
{
    public Animator anim;
    public float speed = 2f;
    public bool isMoving = false;

    private StateInput input;
    private Transform trans;
    private float prevX;
    private float prevZ;
    private Rigidbody body;
    private int frameCount = 0;

    // Use this for initialization
    void Awake()
    {
        body = GetComponent<Rigidbody>();
        input = GetComponent<StateInput>();
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            frameCount++;
            isMoving = (prevZ - trans.position.z < 30 && prevZ - trans.position.z > -30 && prevX - trans.position.x < 30 && prevX - trans.position.x > -30 && frameCount<30);
        }
        if (!isMoving)
        {
            frameCount = 0;
            body.velocity = new Vector3(0, 0, 0);
            if (input.leftTrigger)
                transform.Rotate(0, 90, 0);
            if (input.rightTrigger)
                transform.Rotate(0, -90, 0);
            if (transform.rotation.eulerAngles.y == 270)
            {

                if (input.forwardTrigger)
                {
                    body.velocity = new Vector3(-speed, 0, 0);
                    prevX = trans.position.x;
                    prevZ = trans.position.z;
                    isMoving = true;
                }
                if (input.backwardTrigger)
                {
                    body.velocity = new Vector3(speed, 0, 0);
                    prevX = trans.position.x;
                    prevZ = trans.position.z;
                    isMoving = true;
                }
            }
            if (transform.rotation.eulerAngles.y == 90)
            {

                if (input.forwardTrigger)
                {
                    body.velocity = new Vector3(speed, 0, 0);
                    prevX = trans.position.x;
                    prevZ = trans.position.z;
                    isMoving = true;
                }
                if (input.backwardTrigger)
                {
                    body.velocity = new Vector3(-speed, 0, 0);
                    prevX = trans.position.x;
                    prevZ = trans.position.z;
                    isMoving = true;
                }
            }
            if (transform.rotation.eulerAngles.y == 0)
            {

                if (input.forwardTrigger)
                {
                    body.velocity = new Vector3(0, 0, speed);
                    prevX = trans.position.x;
                    prevZ = trans.position.z;
                    isMoving = true;
                }
                if (input.backwardTrigger)
                {
                    body.velocity = new Vector3(0, 0, -speed);
                    prevX = trans.position.x;
                    prevZ = trans.position.z;
                    isMoving = true;
                }
            }
            if (transform.rotation.eulerAngles.y == 180)
            {

                if (input.forwardTrigger)
                {
                    body.velocity = new Vector3(0, 0, -speed);
                    prevX = trans.position.x;
                    prevZ = trans.position.z;
                    isMoving = true;
                }
                if (input.backwardTrigger)
                {
                    body.velocity = new Vector3(0, 0, speed);
                    prevX = trans.position.x;
                    prevZ = trans.position.z;
                    isMoving = true;
                }
            }
        }
        print(prevX+" "+prevZ+" "+trans.position);
        print(isMoving);
        print(body.velocity);
    }
}
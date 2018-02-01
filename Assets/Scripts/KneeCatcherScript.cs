using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KneeCatcherScript : MonoBehaviour
{

    //Invert the object values in unity engine

    public GameObject rightKnee;
    public GameObject leftKnee;
    public GameObject rightFoot;
    public GameObject leftFoot;

    public Text gameText;
    public bool didStep = false;
    public bool inPosition = true;
    public GameObject trail;
    private float resultOfSlider = 0.85f;

    private float position;
    private bool isUpLeft = false;
    private bool isUpRight = false;

    private float yRight;
    private float yLeft;
    // Use this for initialization
    void Start()
    {
        position = 0.8f;
        yRight = rightKnee.transform.position.y;
        float yLeft = leftKnee.transform.position.y;

        print(resultOfSlider);
    }

    // Update is called once per frame
    void Update()
    {
        didStep = false;

        if (rightKnee.transform.position.y > leftKnee.transform.position.y+0.08)
            isUpLeft = true;
        if (rightKnee.transform.position.y < leftKnee.transform.position.y+0.03)
        {
            if (isUpLeft)
            {
                isUpLeft = false;
                didStep = true;
                Instantiate(trail,transform.position,transform.rotation);
            }
        }

        if (leftKnee.transform.position.y > rightKnee.transform.position.y+0.08)
            isUpRight = true;
        if (leftKnee.transform.position.y < rightKnee.transform.position.y+0.03)
        {
            if (isUpRight)
            {
                isUpRight = false;
                didStep = true;
                Instantiate(trail, transform.position, transform.rotation);
            }
        }

        //print("inPosition: " + inPosition + ", isUpLeft: " + isUpLeft + ", isUpRight:" + isUpRight + ", step:" + didStep + ", rightPos: " + rightKnee.transform.position.y + ", leftPos: " + leftKnee.transform.position.y);
        if (inPosition)
            gameText.text = "Steps: " + didStep;
        if(didStep)
            print(didStep);
        print(resultOfSlider);
    }
}

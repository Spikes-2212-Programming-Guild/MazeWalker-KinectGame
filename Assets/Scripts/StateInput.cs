using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateInput : MonoBehaviour {

    public Animator anim;
    public bool rightTrigger;
    public bool forwardTrigger;
    public bool backwardTrigger;
    public bool leftTrigger;
    public KneeCatcherScript kinect;
    public GUIText gestureInfo;

    // Use this for initialization
    void Awake()
    {
        kinect.GetComponent<KneeCatcherScript>();
    }

	void Update ()
    {

        leftTrigger = gestureInfo.text.Equals("SwipeRight detected");
        rightTrigger = gestureInfo.text.Equals("SwipeLeft detected");
        forwardTrigger = kinect.didStep;
        backwardTrigger = Input.GetKey(KeyCode.DownArrow);

        gestureInfo.text = "Sombody toucha my spaghet!!!";
	}
	/*change values to be positve*/
	

}

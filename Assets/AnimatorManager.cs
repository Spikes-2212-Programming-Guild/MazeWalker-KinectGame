using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour {

    public Animator animator;

    public KneeCatcherScript kinect;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (kinect.didStep)
            animator.SetBool("isMoving", true);

	}
}

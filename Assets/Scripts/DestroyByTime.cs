using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour {

    public float timeUntilKilled = 100f;
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, timeUntilKilled);
	}
}

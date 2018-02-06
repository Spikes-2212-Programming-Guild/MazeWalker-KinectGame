using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndMaze : MonoBehaviour {
    public GameObject Player;
    public GameObject endGameImage;
    public Text timeText;
    public Text currentTimeText;
    public KneeCatcherScript kinect;

    private float timeSinceGameStarted = 0;
    // Use this for initialization
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject == Player)
        {
            endGameImage.SetActive(true);
            timeText.text = "Your time \nwas: "+(int)(timeSinceGameStarted);
            Destroy(currentTimeText.gameObject);
        }
    }

    private void Update()
    {
            timeSinceGameStarted += Time.deltaTime;
            currentTimeText.text = "Time: " + (int)(timeSinceGameStarted);


    }
}


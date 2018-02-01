using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortMazeScript : MonoBehaviour {

    public GameObject loadingScreen;

    public void StartOnClick()
    {
        loadingScreen.SetActive(true);
        Application.LoadLevel(5);
    }
}

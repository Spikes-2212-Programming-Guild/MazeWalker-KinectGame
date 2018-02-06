using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameButton : MonoBehaviour {

    public GameObject camera;

    public void returnToMenu()
    {
        Destroy(camera);
        Application.LoadLevel(2);
    }
}

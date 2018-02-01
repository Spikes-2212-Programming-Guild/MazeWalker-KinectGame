using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameButton : MonoBehaviour {

    public void returnToMenu()
    {
        Application.LoadLevel(2);
    }
}

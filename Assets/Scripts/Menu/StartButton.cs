using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour {

    public Text text;

    public void StartOnClick()
    {

        Application.LoadLevel(2);
    }

}

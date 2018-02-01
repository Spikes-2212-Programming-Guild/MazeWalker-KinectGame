using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fullscreen : MonoBehaviour {
    public Toggle toggle;
    public bool isOn;

    void Awake()
    {
        toggle = GetComponent<Toggle>();
        isOn = toggle.isOn;
    }
    void Update()
    {
        isOn = toggle.isOn;
        if (isOn == true)
            Screen.SetResolution(1280,720,true);
        else
        {
            Screen.SetResolution(1280, 720, false);
        }
    }
}

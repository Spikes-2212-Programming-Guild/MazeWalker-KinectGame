using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LegHeightController : MonoBehaviour {

    public Text sliderText;

    public float resultOfSlider = 8.5f;

	// Use this for initialization
	public void SliderController (float value) {
        int temp = (int)(value * 100);
        resultOfSlider = (float)(8.5 + (float)(temp) / 100);
        sliderText.text = "Leg's height: " + resultOfSlider;
    }
}

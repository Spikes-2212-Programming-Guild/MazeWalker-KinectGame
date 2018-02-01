using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quality : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    public void Fastest()
    {
        QualitySettings.SetQualityLevel(0);
    }

    public void Fast()
    {
        QualitySettings.SetQualityLevel(1);
    }

    public void Simple()
    {
        QualitySettings.SetQualityLevel(2);
    }

    public void Good()
    {
        QualitySettings.SetQualityLevel(3);
    }

    public void Beautiful()
    {
        QualitySettings.SetQualityLevel(4);
    }

    public void Fantastic()
    {
        QualitySettings.SetQualityLevel(5);
    }
}

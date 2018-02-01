using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn_Maze1_2D : MonoBehaviour
{
    public GameObject loadingScreen;

    public void StartOnClick()
    {
        loadingScreen.SetActive(true);
        Application.LoadLevel(4);
    }
}

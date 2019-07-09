using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButtons : MonoBehaviour
{
    public Button StartButton;
    void Start()
    {
        StartButton.onClick.AddListener(LoadSecen);
        Screen.SetResolution(320, 152, false);
    }

    private void LoadSecen()
    {
        SceneManager.LoadScene("Play");
    }
}

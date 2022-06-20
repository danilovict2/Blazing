﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DelayStages2_3 : MonoBehaviour
{
    public void ButtonFunction()
    {
        StartCoroutine(DelaySceneLoad());
    }

    IEnumerator DelaySceneLoad()
    {
        yield return new WaitForSeconds(1f); // Wait 3 seconds
        SceneManager.LoadScene("stages2_3"); // Change to the ID or Name of the scene to load
    }
}
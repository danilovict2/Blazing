using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DelayTeam_2 : MonoBehaviour
{
    public void ButtonFunction()
    {
        StartCoroutine(DelaySceneLoad());
    }

    IEnumerator DelaySceneLoad()
    {
        yield return new WaitForSeconds(1f); // Wait 3 seconds
        SceneManager.LoadScene("team_2"); // Change to the ID or Name of the scene to load
    }
}
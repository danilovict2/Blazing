using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneWithButton : MonoBehaviour
{

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    /*public void Summons_scene(){
        SceneManager.LoadScene("summons");
    }
    public void Summons_confirmation_scene(){
        SceneManager.LoadScene("summonConfirmation");
    }
    public void MainMenu(){
        SceneManager.LoadScene("mainmenu");
    }

    public void Pulling_scene(){
        SceneManager.LoadScene("pullingScreenSingles");
    }

    public void Pulling_sceneMultis(){
        SceneManager.LoadScene("pullingScreenMultis");
    }*/
}

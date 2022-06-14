 using System.Collections;
 using UnityEngine;
 using UnityEngine.SceneManagement;
 
 public class SceneChange : MonoBehaviour
 {
     public float delay = 440;
     public string NewLevel= "Bootcamp";
     void Start()
     {
         StartCoroutine(LoadLevelAfterDelay(delay));
     }
 
     IEnumerator LoadLevelAfterDelay(float delay)
     {
         yield return new WaitForSeconds(delay);
         SceneManager.LoadScene(NewLevel);
     }
 }
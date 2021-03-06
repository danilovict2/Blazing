 using System.Collections;
 using UnityEngine;
 using UnityEngine.SceneManagement;
 
 public class SceneChangeDestroy : MonoBehaviour
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
		 Destroy(GameObject.Find("Naruto Shippuden Ultimate Ninja Blazing BGM 1"));
         SceneManager.LoadScene(NewLevel);
     }
 }
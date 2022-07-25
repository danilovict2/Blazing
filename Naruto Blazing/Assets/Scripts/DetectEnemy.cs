using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnemy : MonoBehaviour
{
    public List<GameObject> Enemies;
    private void OnTriggerEnter2D(Collider2D other) {
        if(!Input.GetMouseButton(0)){
            Debug.Log("Detected After realease");
            if(other.gameObject.tag == "Enemy"){
                Enemies.Add(other.gameObject);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Enemies.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

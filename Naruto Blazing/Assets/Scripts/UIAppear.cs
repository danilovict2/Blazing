using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour
{
	[SerializeField] private SpriteRenderer customImage;
	
    void OnTriggerEnter2D(Collider2D data)
    {
        if (data.CompareTag("Player"))
		{
			customImage.enabled = true;
		}
    }

    void OnTriggerExit2D(Collider2D data)
    {
        if (data.CompareTag("Player"))
		{
			customImage.enabled = false;
		}
    }
}

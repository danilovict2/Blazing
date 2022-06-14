using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear2 : MonoBehaviour
{
	[SerializeField] private SpriteRenderer customImage;
	public AudioSource playSound;

	void OnTriggerEnter2D(Collider2D data)
	{
		if (data.CompareTag("Player"))
		{
			customImage.enabled = true;
			playSound.Play();
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

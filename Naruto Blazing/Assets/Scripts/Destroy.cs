using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{
	public GameObject narutokid_clone;
	private SpriteRenderer spriteRenderer;

	void OnMouseDown()
    {
		spriteRenderer = narutokid_clone.GetComponent<SpriteRenderer>();
		spriteRenderer.enabled = true;
	}
	
	void OnMouseUp()
    {
		spriteRenderer = narutokid_clone.GetComponent<SpriteRenderer>();
		spriteRenderer.enabled = false;
	}
}
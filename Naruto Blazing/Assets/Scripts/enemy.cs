using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour
{
	public GameObject teleport_0, rasengan, narutokid_0, bt_com_system1, commse0_00119;
	public SpriteRenderer spriteRenderer;

	void OnMouseUp()
	{
		this.spriteRenderer = GetComponent<SpriteRenderer>();
		teleport_0.SetActive(true);
		rasengan.SetActive(false);
		this.spriteRenderer.enabled = false;
		bt_com_system1.SetActive(false);
		commse0_00119.SetActive(true);
	}
}
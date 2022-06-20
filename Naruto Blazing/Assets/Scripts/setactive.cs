using UnityEngine;
using System.Collections;

public class setactive : MonoBehaviour
{
	public GameObject teleport_0, rasengan, bt_com_system1, bt_com_system2, bt_com_system3, bt_com_system4, bt_com_system5, bt_com_system6, bt_com_system7, bt_com_system8, bt_com_system9, bt_com_system10, commse0_00119, enemy_0, enemy_1, damage1, damage2, damage3;
	public SpriteRenderer spriteRenderer;
	private SpriteRenderer box;

	void OnMouseUp()
	{
		teleport_0.SetActive(true);
		rasengan.SetActive(false);
		this.spriteRenderer = GetComponent<SpriteRenderer>();
		this.spriteRenderer.enabled = false;
		box = bt_com_system1.GetComponent<SpriteRenderer>();
		box.enabled = false;
		box = bt_com_system2.GetComponent<SpriteRenderer>();
		box.enabled = false;
		box = bt_com_system3.GetComponent<SpriteRenderer>();
		box.enabled = false;
		box = bt_com_system4.GetComponent<SpriteRenderer>();
		box.enabled = false;
		box = bt_com_system5.GetComponent<SpriteRenderer>();
		box.enabled = false;
		box = bt_com_system6.GetComponent<SpriteRenderer>();
		box.enabled = false;
		box = bt_com_system7.GetComponent<SpriteRenderer>();
		box.enabled = false;
		box = bt_com_system8.GetComponent<SpriteRenderer>();
		box.enabled = false;
		box = bt_com_system9.GetComponent<SpriteRenderer>();
		box.enabled = false;
		box = bt_com_system10.GetComponent<SpriteRenderer>();
		box.enabled = false;
		commse0_00119.SetActive(true);
		enemy_0.SetActive(false);
		enemy_1.SetActive(true);
		damage1.SetActive(true);
		damage2.SetActive(true);
		damage3.SetActive(true);
	}
}
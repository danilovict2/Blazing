﻿using UnityEngine;
using System.Collections;

public class setactive1 : MonoBehaviour
{
	public GameObject teleport_0, rasengan, bt_com_system1, bt_com_system2, bt_com_system3, bt_com_system4, bt_com_system5, bt_com_system6, bt_com_system7, bt_com_system8, bt_com_system9, bt_com_system10, bt_com_system1_1, bt_com_system1_2, bt_com_system1_3, bt_com_system1_4, bt_com_system1_5, bt_com_system1_6, bt_com_system1_7, bt_com_system1_8, bt_com_system1_9, bt_com_system1_10, commse0_00119, enemy_0, enemy_1, enemy_2_0, enemy_2_1, damage1, damage2, damage3, damage5;
	public SpriteRenderer spriteRenderer;
	private SpriteRenderer box;

	void OnMouseUp()
	{
		this.spriteRenderer = GetComponent<SpriteRenderer>();
		this.spriteRenderer.enabled = false;
		teleport_0.SetActive(true);
		rasengan.SetActive(false);
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
		box = bt_com_system1_1.GetComponent<SpriteRenderer>();
		box.enabled = false;
		box = bt_com_system1_2.GetComponent<SpriteRenderer>();
		box.enabled = false;
		box = bt_com_system1_3.GetComponent<SpriteRenderer>();
		box.enabled = false;
		box = bt_com_system1_4.GetComponent<SpriteRenderer>();
		box.enabled = false;
		box = bt_com_system1_5.GetComponent<SpriteRenderer>();
		box.enabled = false;
		box = bt_com_system1_6.GetComponent<SpriteRenderer>();
		box.enabled = false;
		box = bt_com_system1_7.GetComponent<SpriteRenderer>();
		box.enabled = false;
		box = bt_com_system1_8.GetComponent<SpriteRenderer>();
		box.enabled = false;
		box = bt_com_system1_9.GetComponent<SpriteRenderer>();
		box.enabled = false;
		box = bt_com_system1_10.GetComponent<SpriteRenderer>();
		box.enabled = false;
		commse0_00119.SetActive(true);
		enemy_0.SetActive(false);
		enemy_1.SetActive(true);
		enemy_2_0.SetActive(false);
		enemy_2_1.SetActive(true);
		damage1.SetActive(true);
		damage2.SetActive(true);
		damage3.SetActive(true);
		damage5.SetActive(true);
	}
}
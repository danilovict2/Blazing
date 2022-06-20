﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMouseMove : MonoBehaviour {

    private Vector3 mousePosition;
    private Rigidbody2D rb;
    private Vector2 direction;
    private float moveSpeed = 100f;

    bool canStart = false;

	// Use this for initialization
	void Start () {
		StartCoroutine(waiter());
        rb = GetComponent<Rigidbody2D>();
	}

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(2);
        canStart = true;
    }

	// Update is called once per frame
	void Update () {
		if (!canStart) return;
        if (Input.GetMouseButton(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (mousePosition - transform.position).normalized;
            rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
        }
        else {
            rb.velocity = Vector2.zero;
        }
    }
}

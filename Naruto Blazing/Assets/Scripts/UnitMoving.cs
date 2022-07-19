using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UnitMoving : MonoBehaviour
{
    Vector3 mousePosition;
    Rigidbody2D rb;
    Vector2 direction;
    Animator UnitAnimations;
    float moveSpeed = 100f;

    bool canStart = false;
    

	
	void Start () {
		StartCoroutine(waiter());
        rb = GetComponent<Rigidbody2D>();
        UnitAnimations = GetComponent<Animator>();
	}

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(2);
        canStart = true;
    }

	
	void Update () {
		if (!canStart) return;
        if (Input.GetMouseButton(0))
        {
            
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (mousePosition - transform.position).normalized;
            rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
            UnitAnimations.Play("chr_00002_move");

        }
        else {
            rb.velocity = Vector2.zero;
            UnitAnimations.Play("chr_00002_idle");
        }
    }
}

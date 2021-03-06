using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
	Vector3 startPos;
	Vector3 endPos;
	Vector3 mousePos;
	Vector3 mouseDir;
	Camera cam;
	LineRenderer lr;
	float max = 5;
	
	bool canStart = false;
	
    void Start()
    {
		StartCoroutine(waiter());
        lr = GetComponent<LineRenderer>();
		cam = Camera.main;
    }
	
	IEnumerator waiter()
	{
		yield return new WaitForSeconds(2);
		canStart = true;
	}

    void Update()
    {
		if (!canStart) return;
		
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
		mouseDir = mousePos - gameObject.transform.position;
		mouseDir.z = 0;
		mouseDir = mouseDir.normalized;
		
		if(Input.GetMouseButtonDown(0))
		{
			lr.enabled = true;
		}
		
		if(Input.GetMouseButton(0))
		{
			startPos = gameObject.transform.position;		
			startPos.z = -1;
			lr.SetPosition(0, startPos);	
			endPos = mousePos;
			endPos.z = 0;
			float capLength = Mathf.Clamp(Vector2.Distance(startPos, endPos), 0, max);
			endPos = startPos + (mouseDir * capLength);
			lr.SetPosition(1, endPos);
		}
		
		if(Input.GetMouseButtonUp(0))
		{
			lr.enabled = false;
		}	
    }
}

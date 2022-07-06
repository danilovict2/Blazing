using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UnitMoving : MonoBehaviour
{
    Vector3 drag;
    Camera cam;

    [SerializeField] float speed = 10;

    void Start() {
        cam = Camera.main;
    }

    void OnMouseDown() {
        drag = transform.position - GetMousePos();
    }

    void OnMouseDrag() {
        transform.position = Vector3.MoveTowards(transform.position, GetMousePos() + drag, speed * Time.deltaTime);
    }

    Vector3 GetMousePos() {
        var mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}

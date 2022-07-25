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
    [SerializeField] DetectEnemy DetectedEnemies;
    private Vector2 currentPosition,newPosition;
    bool canStart = false;
    

	
	void Start () {
		StartCoroutine(waiter());
        rb = GetComponent<Rigidbody2D>();
        UnitAnimations = GetComponent<Animator>();
        currentPosition = this.transform.position;
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
            DragUnit();    
            print(rb.velocity);
        }
        else {
            newPosition = rb.velocity;//! This makes problem
            rb.velocity = Vector2.zero;
            this.transform.position = currentPosition;
            Attack();
            ChangePosition(newPosition);
        }
    }
    private void DragUnit(){
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (mousePosition - transform.position).normalized;
        rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
        UnitAnimations.Play("chr_00002_move");
    }
    private void ChangePosition(Vector2 newPosition){
        if(Vector2.Distance(newPosition,this.transform.position)>0.01){
            Vector2 smoothedPosition=Vector2.Lerp(transform.position,newPosition,moveSpeed);
            this.transform.position=smoothedPosition;
        }
        currentPosition = newPosition;
    }
    private void Attack(){
        if(DetectedEnemies.Enemies.Count>0){
            foreach(var enemy in DetectedEnemies.Enemies){
                this.transform.position = new Vector2(enemy.transform.position.x - 0.5f,enemy.transform.position.y);
                UnitAnimations.Play("chr_00002_attack");
            }
        }
        UnitAnimations.Play("chr_00002_idle");
    }
}

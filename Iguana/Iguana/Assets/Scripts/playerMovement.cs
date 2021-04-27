using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

  public float moveSpeed = 4f;

  public Rigidbody2D rb;

  public Transform playerTransform;

  Vector2 movement;

  void Start()
  {
        playerTransform = GetComponent<Transform>();
        moveSpeed = moveSpeed * (playerTransform.localScale.x* playerTransform.localScale.x);
    }

  // Update is called once per frame
  void Update()
  {
    // movement and pointer facing
      movement.x = Input.GetAxisRaw("Horizontal");
      movement.y = Input.GetAxisRaw("Vertical");

      
      
  }

  private void FixedUpdate()
  {
      rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

  }

  void OnTriggerEnter2D(Collider2D target) {

      if(target.tag == "Enemy") {
          GameManager.instance.PlayerDied();
      }

      if (target.tag == "Goal") {
          GameManager.instance.PlayerReachedGoal();
      }

  }

}

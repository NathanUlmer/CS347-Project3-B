using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandomAngle : MonoBehaviour {

    public float moveSpeed;

    [SerializeField]
    private bool moveLeft;



    private Vector3 RandomVector(float min, float max) {

      var x = Random.Range(min, max);
      var y = Random.Range(min, max);
      var z = Random.Range(min, max);
      return new Vector3(x, y, z);
    }


    void Start() {
        var rb = GetComponent<Rigidbody2D>();
        rb.velocity = RandomVector(-10f, 10f);

    }



} // class

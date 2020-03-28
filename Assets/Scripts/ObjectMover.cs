using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour {
    private Rigidbody2D rigBody;
    
    private float velX;
    private float velY;

    public float moveSpeed;

    void Start() {
        rigBody = GetComponent<Rigidbody2D>();
    }

    void Update() {
        velX = moveSpeed;
        velY = 0;
        rigBody.velocity = new Vector2(velX, velY * moveSpeed);

        if(this.transform.position.x > 8.5 || this.transform.position.x < -8.5) {
            Destroy(this.gameObject);
        }
    }
}

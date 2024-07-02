using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{

  
    public float movSpeed;
    public bool isPlayer1;

    float speedX, speedY;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            speedX = Input.GetAxisRaw("HorizontalP1") * movSpeed;
            speedY = Input.GetAxisRaw("VerticalP1") * movSpeed;
        }
        else
        {
            speedX = Input.GetAxisRaw("HorizontalP2") * movSpeed;
            speedY = Input.GetAxisRaw("VerticalP2") * movSpeed;
        }
        rb.velocity = new Vector2(speedX, speedY);
    }

}

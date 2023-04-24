using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float playerSpeed;
    public float upForce = 5.0f;
    

    public bool player;

    private float xMove;
    private bool jumpFlag;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {
        playerMove();

        
    }

    private void playerMove()
    {
        float xMove = Input.GetAxisRaw("Horizontal");

        float yMove = Input.GetAxisRaw("Vertical");

        transform.Translate(xMove * playerSpeed * Time.deltaTime, 0, 0);

        transform.Translate(0, yMove * playerSpeed * Time.deltaTime, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpFlag = true;
        }
    }


    private void FixedUpdate()
     {
        
        if (jumpFlag)
        {
            rb.AddForce(Vector3.up * upForce, ForceMode2D.Impulse);

            jumpFlag = false;
        }
    }

}

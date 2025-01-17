using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D theRB;

    public float moveSpeed;

    public float jumpForce;

    public Transform groundPoint;
    private bool isOnGround;
    public LayerMask whatisGround;

    public Animator anim;

    public BulletController shotToFire;
    public Transform shotPoint;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, theRB.velocity.y);

        if(theRB.velocity.x<0)
        {
            transform.localScale = new Vector2(-1f, 1f);
        }
        else if(theRB.velocity.x > 0)
        {
            transform.localScale = Vector3.one;
        }

        isOnGround = Physics2D.OverlapCircle(groundPoint.position, .2f, whatisGround);


        if(Input.GetButtonDown("Jump") && isOnGround)
        {
            theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
        }

        if (Input.GetButtonDown("Fire1"))
            {
                    Instantiate(shotToFire, shotPoint.position, shotPoint.rotation).moveDir = new Vector2(transform.localScale.x, 0f);

                    anim.SetTrigger("shotFired");
            }



        anim.SetBool("isOnGround", isOnGround);
        anim.SetFloat("speed", Mathf.Abs(theRB.velocity.x));

    }
}

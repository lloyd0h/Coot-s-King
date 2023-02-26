using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{   

    //started from Outrages Jump King tutorial and modified the script a bit to suit my needs. Will keep adding
    //To do: Animation stuffs for movement and jumping. SFX implementation. Testing and mechanic finalization. 

    public Slider slider;

    public float maxJump; //max jump value or "power" level that jump can be charged to
    public float maxJumpForce; //speed of jump in air (force through air) default value is 10

    public float walkSpeed;
    private float moveInput;
    public bool isGrounded;
    private Rigidbody2D rb;
    public LayerMask groundMask;

    public PhysicsMaterial2D bounceMat, normalMat;
    public bool canJump = true;
    public float jumpValue = 0.0f;

    public bool decrementTimer = false;

    public Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        slider.maxValue = maxJump;
        slider.value = jumpValue;
    }

    // Update is called once per frame
    void Update()
    {

        if (moveInput > 0)
        {

            gameObject.transform.localScale = new Vector3(3, 3, 1);

        }
        if (moveInput < 0)
        {

             gameObject.transform.localScale = new Vector3(-3, 3, 1);


        }

        animator.SetFloat("Speed", Mathf.Abs(moveInput));

        MoveStuffs();

        //slider stuffs
        slider.value = jumpValue;

        if (decrementTimer)
        {
            if (jumpValue > 5)
            {
                 jumpValue -= 0.1f;

            }
            else
            {
                jumpValue = 5;
                decrementTimer = false;
            }
        



        }

    }

    void MoveStuffs()
    {
        moveInput = Input.GetAxisRaw("Horizontal");

        if (jumpValue == 5f && isGrounded)
        {
             rb.velocity = new Vector2(moveInput * walkSpeed, rb.velocity.y);
        }
       

        isGrounded = Physics2D.OverlapBox(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.75f),
        new Vector2(0.9f, 0.4f), 0f, groundMask);


        if (jumpValue >= 0 && !isGrounded)
        {
            rb.sharedMaterial = bounceMat;

        }
        else
        {
            rb.sharedMaterial = normalMat;

        }

        if (Input.GetKey("space") && isGrounded && canJump)
        {
            jumpValue += 0.1f;
        }

        if (jumpValue >= maxJump && isGrounded)
        {
            float tempx = moveInput * maxJumpForce;
            float tempy = jumpValue;
            rb.velocity = new Vector2(tempx, tempy);
            Invoke("ResetJump", 0.2f);

        }

        if (Input.GetKeyDown("space") && isGrounded && canJump)
        {
            rb.velocity = new Vector2(0.0f, rb.velocity.y);

        }

        if (Input.GetKeyUp("space"))
        {      
            if (isGrounded)
            {
                rb.velocity = new Vector2(moveInput * maxJumpForce, jumpValue);
                
                    decrementTimer = true;
                    //jumpValue = 5;
                    
      

            }

            canJump = true;
        }

    }


    void ResetJump()
    {
        canJump = false;
       // jumpValue = 5;
        decrementTimer = true;

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontroller : MonoBehaviour
{
   
    private Animator animator;
    private Rigidbody2D rigid;
    private float x;
    private float y = 0;
    [SerializeField]
    private float movespeed = 0.5f;
    public Gamemanager gamemanager;
    Vector2 vector;
    bool isground;
    bool istouchedright;
    bool istouchedleft;
    [SerializeField]
    private LayerMask groundlayer;
    [SerializeField]
    private float jumpforce;
    private Vector3 foot;
    private Vector3 l_head;
    private Vector3 r_head;

    BoxCollider2D capsuleCollider2D;
    private Vector3 direction;
    private int i = 1;
    private int res = 0;
    private SpriteRenderer spriteRenderer; 
    
    void Start()
    {
        animator = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        capsuleCollider2D = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        //gamemanager = GetComponent<Gamemanager>();
    }
    public void flipx()
    {
        if(spriteRenderer.flipX == true)
        {
            spriteRenderer.flipX = false;
            return;
        }
        else if(spriteRenderer.flipX == false)
        {
            spriteRenderer.flipX = true;
            return;
        }
    }
 
    private void FixedUpdate()
    {
        Bounds bounds = capsuleCollider2D.bounds;
        r_head = new Vector3(bounds.max.x, bounds.max.y);
        l_head = new Vector3(bounds.min.x, bounds.max.y);
        foot = new Vector3(bounds.center.x, bounds.min.y);
        istouchedright = Physics2D.OverlapBox(r_head, new Vector2(1,1), 0, groundlayer);
        istouchedleft = Physics2D.OverlapBox(l_head, new Vector2(1,1), 0, groundlayer);
        isground = Physics2D.OverlapBox(foot, new Vector2(1,1), 0, groundlayer);
        
        if (isground)
        {
            if (istouchedright || istouchedleft)
            {
               // Debug.Log("닿였다.");
                flipx();
          
                i = i * -1;
            }
            direction = new Vector3(i,0,0);
            transform.position += direction * movespeed * Time.deltaTime;

        }
        else if (!isground)
        {
             transform.eulerAngles = new Vector3(0, 0, 0);
        }
    //Debug.Log("wow"+rigid.velocity);
    }
    //player 부활
    void ressurection()
    {
        if (res == 0)
        {
            transform.position = new Vector3(-4, 0, 0);

            rigid.gravityScale = 0;
            res++;
        }
        else if (res == 1)
        {
            rigid.gravityScale = 1;
            res = 0;
        }


    }
    public void velocity0()
    {
        rigid.velocity = Vector2.zero;
    }
    //player 충돌 이벤트
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "spike")
        {
            ressurection();
            Invoke("ressurection",3);
        }
        else if(collision.gameObject.tag == "Finish")
        {
            gamemanager.nextstage();
            movespeed = 0;
        }
        else if (collision.gameObject.tag == "slime")
        {
            rigid.velocity = direction * movespeed + Vector3.up * jumpforce;
        }

    }
    
    // Update is called once per frame
    void Update()
    {
    

        /*if(rigid.velocity.x > maxspeed)
        {
            rigid.velocity = new Vector2(maxspeed,0);
        }*/
        if(rigid.velocity.y > 0)
        {
            rigid.gravityScale = 2f;
        }
   
        if (rigid.velocity.x < -3 && rigid.velocity.x > 3)
        {
            animator.SetBool("isrunning", false);
        }
        else if(rigid.velocity.x <3 && rigid.velocity.x > -3 )
        {
            animator.SetBool("isrunning", true);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{

    [SerializeField]
    LayerMask LayerMask;
    [SerializeField]
    LayerMask LayerMask2;
    SpriteRenderer spriteRenderer;
    [SerializeField]
    float movespeed;
    Vector3 direction;
    bool istouchedright;
    bool istouchedleft;
    bool isground;
    [SerializeField]
    Vector3 vector3;
    Vector3 a;
    private int res = 0;
    private Vector3 foot;
    private Vector3 l_head;
    private Vector3 r_head;
    BoxCollider2D boxCollider2D;
    Rigidbody2D rigid;// Start is called before the first frame update
    void Start()
    {
        a = new Vector3();
        a = vector3;
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        direction = Vector3.left;
        boxCollider2D = GetComponent<BoxCollider2D>();
    }
    void changedirection()
    {
        if (direction == Vector3.left)
            direction = Vector3.right;
        else if (direction == Vector3.right)
            direction = Vector3.left;
    }
    public void flipx()
    {
        if (spriteRenderer.flipX == true)
        {
            spriteRenderer.flipX = false;
            return;
        }
        else if (spriteRenderer.flipX == false)
        {
            spriteRenderer.flipX = true;
            return;
        }
    }
    void ressurection()
    {
        if (res == 0)
        {
            transform.position = a;
            rigid.gravityScale = 0;
            res++;
        }
        else if (res == 1)
        {
            rigid.gravityScale = 1;
            res = 0;
        }


    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "spike")
        {
            ressurection();
            Invoke("ressurection", 3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Bounds bounds = boxCollider2D.bounds;
        r_head = new Vector3(bounds.max.x, bounds.max.y);
        l_head = new Vector3(bounds.min.x, bounds.max.y);
        foot = new Vector3(bounds.center.x, bounds.min.y);

        istouchedright = Physics2D.OverlapBox(r_head, new Vector2(1, 1), 0, LayerMask);
        istouchedleft = Physics2D.OverlapBox(l_head, new Vector2(1, 1), 0, LayerMask2);
        isground = Physics2D.OverlapBox(foot, new Vector2(1, 1), 0, LayerMask);
        if (isground)
        {
            if (istouchedleft || istouchedright)
            {
                flipx();
                changedirection();

            }
        transform.position += direction * movespeed * Time.deltaTime;
        }
        //∂•ø° ∂≥æÓ¡Æ¿÷¿∏∏È ∏ÿ√ﬂ±‚!
        if (!isground)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        
    }
}
       

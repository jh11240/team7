using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikecollision: MonoBehaviour
{
    [SerializeField]
    GameObject game;
    [SerializeField]
    GameObject game2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.transform.position = new Vector3(-4, 0, 0);
        }
    }

    
    // Update is called once per frame
    private void fixedUpdate()
    {
        

    }
}

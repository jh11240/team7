using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 숫자키로오브젝트지정 : MonoBehaviour
{
    [SerializeField]
    private KeyCode KeyCode;
    [SerializeField]
    private float movespeed;
    [SerializeField]
    GameObject GameObject;

    SpriteRenderer SpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer=GetComponent<SpriteRenderer>();
 
    }

   

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey(KeyCode))
        {
            SpriteRenderer.color = Color.black;
            if (Input.GetKey(KeyCode.UpArrow)) {
                                GameObject.transform.position += Vector3.up * movespeed*Time.deltaTime;
                    }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                GameObject.transform.position += Vector3.down * movespeed * Time.deltaTime;
            }
        }
        if (Input.GetKeyUp(KeyCode))
        {
            SpriteRenderer.color = Color.white;
        }
        
    }
}

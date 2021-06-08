using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimeobject : MonoBehaviour
{

    [SerializeField]
    private int jumpforce;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnCollsionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.otherRigidbody.AddForce(new Vector3(0, 1, 0)*jumpforce, ForceMode2D.Impulse);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

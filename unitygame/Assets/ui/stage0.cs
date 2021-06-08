using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage0 : MonoBehaviour
{

    public Gamemanager gamemanager;

    // Start is called before the first frame update
    void Awake()
    {
  
        //ui.enabled = false;
    }
    public void onclickstart()
    {
        gamemanager.nextstage();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
  
}

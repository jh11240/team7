using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stagelast : MonoBehaviour
{
 
    public Gamemanager gamemanager;

    // Start is called before the first frame update
    void Awake()
    {
 
        //ui.enabled = false;
    }
    public void onclickrestart()
    {
        gamemanager.loadscene();
    }
    public void clickgameexit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    // Update is called once per frame
    void Update()
    {

    }
}

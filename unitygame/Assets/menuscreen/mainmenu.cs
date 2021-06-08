using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public Gamemanager gma;
    public Canvas startmenu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onclick0()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Sample Scene");
    }
    public void onclick1()
    {
        Debug.Log("1번누름");
    }
    public void onclick2()
    {
        Debug.Log("2번누름");
    }
    /*public void onclickrestart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Sample Scene");
    }*/
    public void onclickquit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}

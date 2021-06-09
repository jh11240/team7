using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public main_load ml;
    
    public void ClickMenu()
    {
        //string nowbutton = EventSystem.current.currentSelectedGameObject.name;
        SceneManager.LoadScene("main");
        //if (nowbutton == "menu1") ml.st = 1;
        //else if (nowbutton == "menu2") ml.st = 2;
        //else if (nowbutton == "menu3") ml.st = 3;
    }
}

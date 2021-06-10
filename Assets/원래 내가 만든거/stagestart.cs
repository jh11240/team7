using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stagestart : MonoBehaviour
{

    public Gamemanager gamemanager;

    public void onclickstart()
    {
        gamemanager.nextstage();
    }
}


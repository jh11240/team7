using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage0 : MonoBehaviour
{
    public Gamemanager gamemanager;

    public void onclickstart()
    {
        gamemanager.nextstage();
    }
}

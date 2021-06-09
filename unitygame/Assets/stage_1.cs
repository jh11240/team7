using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stage_1 : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("stage1");
    }
}

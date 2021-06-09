using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gamemanager : MonoBehaviour
{
    public int stageindex;
    public playercontroller player;
    [SerializeField]
    public GameObject[] stages;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void nextstage()
    {
        if (stageindex <= stages.Length - 1)
        {
            Debug.Log("wow");
            stages[stageindex].SetActive(false);
            stageindex++;
            stages[stageindex].SetActive(true);
            playerposition();
        }
        else
        {
            Time.timeScale = 0;
            Debug.Log("게임 클리어");
            //loadscene();
        }
        
    }
    //player 첨 등장할 위치
    void playerposition()
    {
        player.transform.position = new Vector3(-4, 0, -1);
        player.velocity0();    
    }
    public void loadscene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
    // Update is called once per frame
    void Update()
    { 
    }
}

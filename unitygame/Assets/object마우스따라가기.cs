using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object마우스따라가기 : MonoBehaviour
{
    Transform me;
    Vector3 screenposition;
    Vector3 relative;
    bool clicked;
    [SerializeField]
    GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        me = transform;
    }
    private void OnMouseDown()
    {//큐브의 월드 좌표 는 transform.position으로 알수있음
        //input.mouseposition은 마우스 위치 스크린좌표 반환
        //스크린좌표는 해상도 크기와 매치 좌측 아래를 (0,0)
     
   
        screenposition = Camera.main.WorldToScreenPoint(transform.position);
        relative = screenposition - Input.mousePosition;
        clicked = true;
        Debug.Log("마우스 클릭다운");
    }
    private void OnMouseDrag()
    {
        if(clicked)
        {
            gameObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition + relative);
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                gameObject.transform.position = Camera.main.ScreenToWorldPoint(screenposition);
                clicked = false;
                Debug.Log("esc 버튼");
            }
        }
    }
    private void OnMouseUp()
    {
        clicked = false;
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

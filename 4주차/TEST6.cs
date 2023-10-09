using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST6 : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("아무키를 눌렀습니다.");
        if (Input.anyKey)
            Debug.Log("아무키를 누르고있습니다.");
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("items buyed");
        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("아무키를 눌렀습니다.");
        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("이동을 멈춤");
        if (Input.GetMouseButtonDown(0))
            Debug.Log("발사");
        if (Input.GetMouseButton(0))
            Debug.Log("충전");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 발사");

        if(Input.GetKeyDown("Jump"))
            Debug.Log(" 점프");
        if (Input.GetKey("Jump"))
            Debug.Log(" 점프 준비중.");
        if (Input.GetKeyUp("Jump"))
            Debug.Log(" 슈퍼 점프");
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log(" 횡이동중." + Input.GetAxis("Horizontal"));
            Debug.Log(" 횡이동중." + Input.GetAxisRaw("Horizontal"));
        }
        if (Input.GetButton("Vertical"))
        {
            Debug.Log(" 종이동중." + Input.GetAxis("Vertical"));

        }
       // size로 키 사용 개수 정하기 가능
    }


    void Start()
    {
        Vector3 vec = new Vector3(2, 0.1f, 2);
        transform.Translate(vec);
        Vector2 vec2 = new Vector2(
            Input.GetAxis("Horizontal"),
             Input.GetAxis("Vertical")
            );
        transform.Translate(vec2);
        // 카메라에 넣으면 카메라도 같이 따라감
    }

    

}

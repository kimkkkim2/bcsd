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
            Debug.Log("�ƹ�Ű�� �������ϴ�.");
        if (Input.anyKey)
            Debug.Log("�ƹ�Ű�� �������ֽ��ϴ�.");
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("items buyed");
        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("�ƹ�Ű�� �������ϴ�.");
        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("�̵��� ����");
        if (Input.GetMouseButtonDown(0))
            Debug.Log("�߻�");
        if (Input.GetMouseButton(0))
            Debug.Log("����");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� �߻�");

        if(Input.GetKeyDown("Jump"))
            Debug.Log(" ����");
        if (Input.GetKey("Jump"))
            Debug.Log(" ���� �غ���.");
        if (Input.GetKeyUp("Jump"))
            Debug.Log(" ���� ����");
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log(" Ⱦ�̵���." + Input.GetAxis("Horizontal"));
            Debug.Log(" Ⱦ�̵���." + Input.GetAxisRaw("Horizontal"));
        }
        if (Input.GetButton("Vertical"))
        {
            Debug.Log(" ���̵���." + Input.GetAxis("Vertical"));

        }
       // size�� Ű ��� ���� ���ϱ� ����
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
        // ī�޶� ������ ī�޶� ���� ����
    }

    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mytest10 : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = Vector2.right;
        rigid.velocity = Vector2.left;
        //rigid.velocity = new Vector2(2,2);
        // rigid.AddForce(Vector3.up*50, ForceMode.Impulse);
        //���� ����, ���� Ŭ���� �� ���� �� �ʿ�
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {// ���� ���� �ִ� update
        if (Input.GetButtonDown("Jump")) ;
        //rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
        //Debug,Log("rigid.velocity ")

        Input.GetAxisRaw("Horizental");
        Input.GetAxisRaw("Vertical");
        //ȸ����
        //rigid.AddTorque(Vector3.up);
    }





}

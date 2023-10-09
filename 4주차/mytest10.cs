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
        //힘의 방향, 무게 클수록 더 많은 힘 필요
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {// 물리 현상 넣는 update
        if (Input.GetButtonDown("Jump")) ;
        //rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
        //Debug,Log("rigid.velocity ")

        Input.GetAxisRaw("Horizental");
        Input.GetAxisRaw("Vertical");
        //회전력
        //rigid.AddTorque(Vector3.up);
    }





}

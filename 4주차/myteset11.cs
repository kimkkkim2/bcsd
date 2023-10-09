using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myteset11 : MonoBehaviour
{

    MeshRenderer mash; // 오브젝트 재질 접근
    Material mat;
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        mash = GetComponent<MeshRenderer>();
        mat = mash.material;
        rigid.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
        // COLLSION : 충돌 정보
        // Oncollision ender/stat/exit 물리적 충돌 시작/중/끝 호출 
    {
        if(collision.gameObject.name == "My Ball")
            mat.color = new Color(0, 0, 0);
    }


    private void OnCollisionExit(Collision collision)
    // COLLSION : 충돌 정보
    // Oncollision ender/stat/exit 물리적 충돌 시작/중/끝 호출 
    {
        if (collision.gameObject.name == "My Ball")
            mat.color = new Color(1, 1, 1);
    }
    // 트리거 이벤트
    // 투명 벽 : 재질 > rendering mode > transparent, color의 알파값 내리기
    // collider의 is 트리거 체크, 
    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 3, ForceMode.Impulse);
    }





}

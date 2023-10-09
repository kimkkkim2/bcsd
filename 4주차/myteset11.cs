using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myteset11 : MonoBehaviour
{

    MeshRenderer mash; // ������Ʈ ���� ����
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
        // COLLSION : �浹 ����
        // Oncollision ender/stat/exit ������ �浹 ����/��/�� ȣ�� 
    {
        if(collision.gameObject.name == "My Ball")
            mat.color = new Color(0, 0, 0);
    }


    private void OnCollisionExit(Collision collision)
    // COLLSION : �浹 ����
    // Oncollision ender/stat/exit ������ �浹 ����/��/�� ȣ�� 
    {
        if (collision.gameObject.name == "My Ball")
            mat.color = new Color(1, 1, 1);
    }
    // Ʈ���� �̺�Ʈ
    // ���� �� : ���� > rendering mode > transparent, color�� ���İ� ������
    // collider�� is Ʈ���� üũ, 
    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 3, ForceMode.Impulse);
    }





}

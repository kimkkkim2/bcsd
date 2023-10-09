using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test7 : MonoBehaviour
{

    Vector3 target = new Vector3(0, 1.5f, 0);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //���� �̵�
        transform.position =
            Vector3.MoveTowards(transform.position,
            target, 2f);

        //�ε巯�� �̵� �������� ������
        Vector3 velo = Vector3.zero;
        //  Vector3 velo = Vector3.up * 50;
        transform.position =
            Vector3.SmoothDamp(transform.position,
            target, ref velo, 2f);

        //lerp �������� �� ���� ���� ������
        transform.position =
            Vector3.Lerp(transform.position,
            target, 0.01f);
        //Sleerp ���鼱������, ȣ�� �׸��� �̵�
        transform.position =
            Vector3.Slerp(transform.position,
            target, 0.01f);
        Vector3 v = new Vector3(
                Input.GetAxisRaw("Horizontal") * Time.deltaTime,
                Input.GetAxisRaw("Vertical") * Time.deltaTime
            ) ;
        transform.Translate(v);
    }
    // RigidBody ������Ʈ : ��������(ex �߷�)�޵��� �ϴ°�
    // Collider : ������Ʈ���� �ε��� �� �ְ�
    // rigidBody : mass : ����, �浹�� ���ſ���, �߷��� ����
    // use gravity : �߷�,  is kinematic : �ܺ� ����ȿ�� ����,�����̴� ����
    // material : ����, create >  material �� ���� ���� ����
    // material �� metalic : �ݼ� ����, smoothness : �� �ݻ� ��ġ
    // main maps�� albedo �׸� �ȿ� ������ �׸�,�ؽ��� ���� ����
    // material > tiling : �ؽ��� �ݺ� Ÿ�� ����, �Ҽ� : �߷��� ��
    // material > emission : �ؽ��� ��� ����, ���� �� �� �ִ°��� �ƴ�
    // material > 
    //���� ���� : create > physics material : sphere colider�ȿ� ����
    // bounciness : ź���� bonciness combine : ���� ź���� ���� 1�̸� ���ǹ����� ź��
    // friction : ������, �������� �̲����� friction combine : ���� ���� ����
    // ���� friction�ջ��� �ּ� bounciness �ջ����ִ�
    //��ü �ʼ� ��� : mash, material, collider, rigidBody

}

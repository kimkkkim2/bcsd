using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
     void Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");

    }
    void Start()
    {
        Debug.Log("��� ��� ì��");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("���� ���");
    }

    void FixedUpdate()
    {
        Debug.Log("�̵�");
    }
    void LateUpdate()
    {
        Debug.Log("����ġ ȹ��");
    }
    private void OnDestroy()
    {
        Debug.Log("�÷��̾� ������ ����");
    }
    private void OnEnable()
    {
        Debug.Log("�÷��̾� �α���");
    }
    private void OnDisable()
    {
        Debug.Log("�÷��̾� �α׾ƿ�");
    }
}

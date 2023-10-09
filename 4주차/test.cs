using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
     void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");

    }
    void Start()
    {
        Debug.Log("사냥 장비 챙김");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("몬스터 사냥");
    }

    void FixedUpdate()
    {
        Debug.Log("이동");
    }
    void LateUpdate()
    {
        Debug.Log("경험치 획득");
    }
    private void OnDestroy()
    {
        Debug.Log("플레이어 데이터 해제");
    }
    private void OnEnable()
    {
        Debug.Log("플레이어 로그인");
    }
    private void OnDisable()
    {
        Debug.Log("플레이어 로그아웃");
    }
}

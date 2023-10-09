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
        //일정 이동
        transform.position =
            Vector3.MoveTowards(transform.position,
            target, 2f);

        //부드러운 이동 작을수록 빠르게
        Vector3 velo = Vector3.zero;
        //  Vector3 velo = Vector3.up * 50;
        transform.position =
            Vector3.SmoothDamp(transform.position,
            target, ref velo, 2f);

        //lerp 선형보간 값 작을 수록 느리게
        transform.position =
            Vector3.Lerp(transform.position,
            target, 0.01f);
        //Sleerp 구면선형보간, 호를 그리며 이동
        transform.position =
            Vector3.Slerp(transform.position,
            target, 0.01f);
        Vector3 v = new Vector3(
                Input.GetAxisRaw("Horizontal") * Time.deltaTime,
                Input.GetAxisRaw("Vertical") * Time.deltaTime
            ) ;
        transform.Translate(v);
    }
    // RigidBody 컴포넌트 : 물리현상(ex 중력)받도록 하는것
    // Collider : 오브젝트끼리 부딪힐 수 있게
    // rigidBody : mass : 무게, 충돌이 무거워짐, 중력은 깉음
    // use gravity : 중력,  is kinematic : 외부 물리효과 무시,움직이는 함정
    // material : 재질, create >  material 로 재질 설정 가능
    // material 의 metalic : 금속 여부, smoothness : 빛 반사 수치
    // main maps의 albedo 네모 안에 넣으면 그림,텍스터 삽입 가능
    // material > tiling : 텍스터 반복 타일 개수, 소수 : 잘려서 들어감
    // material > emission : 텍스터 밝기 조절, 빛을 낼 수 있는것은 아님
    // material > 
    //물리 재질 : create > physics material : sphere colider안에 있음
    // bounciness : 탄성력 bonciness combine : 다음 탄성을 정함 1이면 거의무한히 탄성
    // friction : 마찰력, 낮을수록 미끄러짐 friction combine : 다음 마찰 정함
    // 보통 friction합산은 최소 bounciness 합산은최대
    //물체 필수 요소 : mash, material, collider, rigidBody

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;  // 탄알의 이동속력
    private Rigidbody bulletRigidbody;
    
    void Start()
    {
        //게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 bulletRigidbody에 할당
        bulletRigidbody = GetComponent<Rigidbody>();
        //리지드바디의 속도 =  앞쪽방향 *이동속력
        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);
        
    }

    // Update is called once per frame 
    void Update()
    {
        
    }
}

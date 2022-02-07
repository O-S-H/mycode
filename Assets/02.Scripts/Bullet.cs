using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;  // ź���� �̵��ӷ�
    private Rigidbody bulletRigidbody;
    
    void Start()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();
        //������ٵ��� �ӵ� =  ���ʹ��� *�̵��ӷ�
        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);
        
    }
   void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayController playController = other.GetComponent<PlayController>();

            if(playController != null) //������Ʈ�� �������µ� �����ߴٸ�
            {
                playController.Die();
            }
        }
    }
    // Update is called once per frame 
    void Update()
    {
        
    }
}

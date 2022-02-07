using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletprefab; //������ ź���� ���� ������
    public float spwnRateMin = 0.5f;// �ּ� ���� �ֱ� 
    public float spwnRateMax = 3f; //���뼺���ֱ�

    private Transform target;
    private float spawnRate;
    private float timeAfterspwn;


    void Start()
    {
        timeAfterspwn = 0f;
        spawnRate = Random.Range(spwnRateMin, spwnRateMax);
        target = FindObjectOfType<PlayController>().transform;
    }


    void Update()
    { 
        timeAfterspwn += Time.deltaTime;
        if (timeAfterspwn >= spawnRate)
        {
            timeAfterspwn = 0f;


            GameObject bullet
                = Instantiate(bulletprefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);
        }








    }       
        
}

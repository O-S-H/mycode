using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletprefab; //생성할 탄알의 원본 프로팹
    public float spwnRateMin = 0.5f;// 최소 생성 주기 
    public float spwnRateMax = 3f; //쵀대성성주기

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

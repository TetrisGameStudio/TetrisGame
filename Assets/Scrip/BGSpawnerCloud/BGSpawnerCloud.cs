using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSpawnerCloud : MonoBehaviour
{
    [SerializeField]
    private GameObject cloud;
    void Start()
    {
        StartCoroutine (Spawner());
    }

    
    IEnumerator Spawner() //Deplay để sinh ra
    {
        yield return new WaitForSeconds(15);
        Vector3 temp = cloud.transform.position;
        temp.y = Random.Range(-2.5f, 2.5f);
        Instantiate(cloud,transform.position, Quaternion.identity);
        StartCoroutine (Spawner());
    }
}

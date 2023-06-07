using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundSpwner : MonoBehaviour
{
    private GameObject spawnBackGround;

    [SerializeField] private int TimeSpawn = 1;

    [SerializeField] private float SpawnRate = 10f;

    [SerializeField] private GameObject TemplateBackGround;



    private void Start()
    {
        InvokeRepeating("BackGround", TimeSpawn, SpawnRate);
    }
    private void BackGround()
    {
        spawnBackGround = Instantiate(TemplateBackGround, transform.position, Quaternion.identity) as GameObject;
    }
}
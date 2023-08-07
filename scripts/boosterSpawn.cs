using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boosterSpawn : MonoBehaviour
{
    public GameObject booster;
    static public GameObject  boosterClone;
    public GameObject bspawner1, bspawner2, bspawner3, bspawner4, bspawner5, bspawner6,
    bspawner7, bspawner8, bspawner9, bspawner10, bspawner11, bspawner12, bspawner13, bspawner14, bspawner15;
    void Start()
    {
        StartCoroutine(createrBooster());
    }
    void Update()
    {

    }
    IEnumerator createrBooster()
    {
        int ran = Random.Range(1, 16);
        switch (ran)
        {
            case 1:
                boosterClone = Instantiate(booster, bspawner1.transform.position, Quaternion.identity);
                break;
            case 2:
                boosterClone = Instantiate(booster, bspawner2.transform.position, Quaternion.identity);
                break;
            case 3:
                boosterClone = Instantiate(booster, bspawner3.transform.position, Quaternion.identity);
                break;
            case 4:
                boosterClone = Instantiate(booster, bspawner4.transform.position, Quaternion.identity);
                break;
            case 5:
                boosterClone = Instantiate(booster, bspawner5.transform.position, Quaternion.identity);
                break;
            case 6:
                boosterClone = Instantiate(booster, bspawner6.transform.position, Quaternion.identity);
                break;
            case 7:
                boosterClone = Instantiate(booster, bspawner7.transform.position, Quaternion.identity);
                break;
            case 8:
                boosterClone = Instantiate(booster, bspawner8.transform.position, Quaternion.identity);
                break;
            case 9:
                boosterClone = Instantiate(booster, bspawner9.transform.position, Quaternion.identity);
                break;
            case 10:
                boosterClone = Instantiate(booster, bspawner10.transform.position, Quaternion.identity);
                break;
            case 11:
                boosterClone = Instantiate(booster, bspawner11.transform.position, Quaternion.identity);
                break;
            case 12:
                boosterClone = Instantiate(booster, bspawner12.transform.position, Quaternion.identity);
                break;
            case 13:
                boosterClone = Instantiate(booster, bspawner13.transform.position, Quaternion.identity);
                break;
            case 14:
                boosterClone = Instantiate(booster, bspawner14.transform.position, Quaternion.identity);
                break;
            case 15:
                boosterClone = Instantiate(booster, bspawner15.transform.position, Quaternion.identity);
                break;
        }
        yield return new WaitForSeconds(10);
    }
}

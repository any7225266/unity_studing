using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class building : MonoBehaviour
{
    [SerializeField] GameObject[] Tower;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SpawnTower()
    {
        int r = Random.Range(0, Tower.Length);
        GameObject floor= Instantiate(Tower[r], transform);
        floor.transform.position = new Vector3(Random.Range(-7f, 7f), Random.Range(-7f, 7f), 0f);
    }
}
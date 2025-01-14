using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class enemies : MonoBehaviour
{
    [SerializeField] GameObject[] bugs;
    [SerializeField] GameObject Canva;
    
    public int bugcount;
    public GameObject newbug;
    [SerializeField] Text newHp;
    
    void Start()
    {
        for (int i=0;i<5;i++)
        {
            Spawnbug();
        }
    }

    public void Update()
    {
        
    }

    public void Spawnbug()
    {
        

        newbug = Instantiate(bugs[0], transform);
        newbug.transform.position = new Vector3(Random.Range(-7f, 7f), Random.Range(-7f, 7f), 0f);
        
        newHp = Canva.GetComponent<Canvas>().SpawnHpBar();
        newHp.GetComponent<Text>().alignment = TextAnchor.MiddleCenter; 
        createlink();
    }

    public void createlink()
    {
        bug bugScript = newbug.GetComponent<bug>();
        bugScript.setHpbar(newHp);
        //bugScript.bug_Hp = newHp;
    }
    
}
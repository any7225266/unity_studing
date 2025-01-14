using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] float AttackDistance;
    [SerializeField] GameObject enemies;
    int killedbug;
    [SerializeField] float tower_time;
    void Start()
    {
        AttackDistance = 5f;
        killedbug = 0;
        tower_time = 0f;
    }

    void Update()
    {
        UpdateHpBar();
    }
    void UpdateHpBar()
    {
        tower_time += Time.deltaTime;
        if (tower_time > 1)
        {
            tower_time -= 1;
            Attack();
        }
        
    }

    void Attack()
    {
        for (int i=enemies.transform.childCount-1;i>=0;i--)
        {
            GameObject abug = enemies.transform.GetChild(i).gameObject;
            float dist = Vector3.Distance(abug.transform.position, transform.position);
            if (dist <= AttackDistance)
            {
                bug bugScript = abug.GetComponent<bug>();
                bugScript.Hp -= 50;
                if (bugScript.Hp <= 0)
                {
                    killedbug++;
                    Debug.Log("killedbug：" + killedbug);
                }
                //abug.transform.parent.GetComponent<enemies>().Spawnbug();
                //Destroy(abug);
                //killedbug++;
                //Debug.Log("killedbug：" + killedbug);
            }
        }
    }
}

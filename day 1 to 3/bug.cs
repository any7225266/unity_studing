using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class bug : MonoBehaviour
{
    [SerializeField] GameObject Tower;
    [SerializeField] GameObject[] Canva;
    [SerializeField] float movespeed = 1;
    [SerializeField] Text bug_Hp;
    public bool alive = true;

    public int Hp;

    void Start()
    {
        Hp = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newposition = Vector3.MoveTowards(transform.position, Tower.transform.position, movespeed * Time.deltaTime);
        transform.position = newposition;
        if (bug_Hp != null)
        {
            UpdateHpBar();
        }
        if (Hp <= 0)
        {
            if (bug_Hp != null)
            {
                bug_Hp.GetComponent<HpBar>().died();
                //bug_Hp.died();
                //bug bugScript = newbug.GetComponent<bug>();
                //bugScript.bug_Hp = newHp;
                //DestroyImmediate(bug_Hp, true);
            }
            //DestroyImmediate(Hp, true);
            Destroy(gameObject);
            transform.parent.GetComponent<enemies>().Spawnbug();
        }
        UpdateHp();
    }

    void UpdateHpBar()
    {
        //Debug.Log(transform.position.x+10);
        bug_Hp.transform.position = new Vector3((transform.position.x+10)/10f*265f, (transform.position.y+11)/10f*265f, 0);
    }

    void UpdateHp()
    {
        if (bug_Hp != null)
        {
            bug_Hp.text = "HP : " + Hp.ToString();
        }
    }

    public void setHpbar(Text newbar)
    {
        bug_Hp = newbar;
    }
}

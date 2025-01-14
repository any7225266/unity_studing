using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{
    [SerializeField] GameObject[] hpbars;
    //[SerializeField] GameObject Hp;
    
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public Text SpawnHpBar()
    {
        GameObject Hpobject = Instantiate(hpbars[0], transform);
        Text Hp = Hpobject.GetComponent<Text>();
        return Hp;
    }
}


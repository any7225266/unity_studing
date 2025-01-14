using UnityEngine;

public class HpBar : MonoBehaviour
{
    [SerializeField] GameObject bug;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void died()
    {
        Destroy(gameObject);
    }
}

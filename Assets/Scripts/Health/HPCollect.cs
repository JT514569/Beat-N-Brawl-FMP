using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPCollect : MonoBehaviour
{

    [SerializeField] private float hpValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.GetComponent<Health>().AddHP(hpValue);
            gameObject.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

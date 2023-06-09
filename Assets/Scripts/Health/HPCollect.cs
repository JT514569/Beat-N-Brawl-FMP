using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPCollect : MonoBehaviour
{

    [SerializeField] private float hpValue;

    [SerializeField] private AudioSource Collectsound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<Health>().AddHP(hpValue);
            Collectsound.Play();
            Destroy(gameObject);

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

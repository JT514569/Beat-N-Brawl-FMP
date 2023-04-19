using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float StartHP;
    public float currentHP { get; private set; }
    private Animator anim;
    private bool dead;

    private void Awake()
    {
        currentHP = StartHP;
        anim = GetComponent<Animator>();
    }
    public void Damage(float _damage)
    {
        currentHP = Mathf.Clamp(currentHP - _damage, 0, StartHP);

        if (currentHP > 0)
        {
            anim.SetTrigger("Hurt");

        }
        else
        {
            if (!dead)
            {
                anim.SetTrigger("Die");
                GetComponent<PlayerMovement>().enabled = false;
                dead = true;
            }

        }
    }

    //    private void Update()
    //    {
    //        if (Input.GetKeyDown(KeyCode.E))
    //            Damage(1);
    //    }
    // }
}
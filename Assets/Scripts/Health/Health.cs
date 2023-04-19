using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float StartHP;
    private float currentHP;

    private void Awake()
    {
        currentHP = StartHP;
    }
    public void Damage(float _damage)
    {
        currentHP = Mathf.Clamp(currentHP - _damage, 0, StartHP);
        if (currentHP > 0)
        {

        }
        else
        {

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float StartHP;
    public float currentHP { get; private set; }

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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            Damage(1);
    }
}

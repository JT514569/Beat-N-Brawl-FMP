using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [Header ("Health")]
    [SerializeField] private float StartHP;
    public float currentHP { get; private set; }
    private Animator anim;
    private bool dead;

    [Header("IFrames")]
    [SerializeField] private float Invulnerability;
    [SerializeField] private float InvinFlashes;
    [SerializeField] private float InvinSeconds;
    private SpriteRenderer spriteRend;
    private void Awake()
    {
        currentHP = StartHP;
        anim = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();
    }
    public void Damage(float _damage)
    {
        currentHP = Mathf.Clamp(currentHP - _damage, 0, StartHP);

        if (currentHP > 0)
        {
            anim.SetTrigger("Hurt");
            StartCoroutine(Invulnerable());

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

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
                Damage(1.25f);
        }

    public void AddHP(float _value)
    {
        currentHP = Mathf.Clamp(currentHP + _value, 0, StartHP);
    }

    private IEnumerator Invulnerable()
    {
        Physics2D.IgnoreLayerCollision(10, 11, true);
        for (int i = 0; i < InvinFlashes; i++)
        {
            spriteRend.color = new Color(1, 0, 0, 0.5f);
            yield return new WaitForSeconds(InvinSeconds);
            spriteRend.color = Color.white;
            yield return new WaitForSeconds(InvinSeconds);
        }
        //Invulnerableness
        Physics2D.IgnoreLayerCollision(10, 11, false);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.IO;

public class HPBar : MonoBehaviour
{
    [SerializeField] private Health PlayerHP;
    [SerializeField] private Image totalHPBar;
    [SerializeField] private Image currentHPBar;

    private void Start()
    {
        totalHPBar.fillAmount = PlayerHP.currentHP / 5;
    }

    private void Update()
    {
        currentHPBar.fillAmount = PlayerHP.currentHP / 5;
    }
}
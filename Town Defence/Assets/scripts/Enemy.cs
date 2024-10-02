using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Image clockTimer;
    [SerializeField] private float _maxTime = 10f;
    [SerializeField] private float _currTimer;
    [SerializeField] private int _enemy;
    [SerializeField] private TextMeshProUGUI _countEnemy;
    void Start()
    {
        
    }

    void Update()
    {
        if (_currTimer >= 0)
        {
            _currTimer -= Time.deltaTime;
            clockTimer.fillAmount = _currTimer / _maxTime;
        }
        else
        {
            _currTimer = _maxTime;
        }
        _countEnemy.text = "Враг " + _enemy.ToString();
    }
}

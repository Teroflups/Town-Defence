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
    [SerializeField] private float _enemy;
    [SerializeField] private TextMeshProUGUI _countEnemy;
    Invite invite;
    [SerializeField] private GameObject _endGame;
    void Start()
    {
        invite = GetComponent<Invite>();
        _currTimer = _maxTime;
    }

    void Update()
    {
        clockTimer.fillAmount = _currTimer / _maxTime;
        if (_currTimer >= 0)
        {
            _currTimer -= Time.deltaTime;
            
        }
        else
        {
            
            if (invite._warrior - _enemy < 0) 
            {
                _enemy -= invite._warrior;
                invite._warrior = 0;    
                if(invite._peasant - _enemy * 3 < 0)
                {
                    invite._peasant = 0;
                    Time.timeScale = 0;
                    _endGame.SetActive(true);
                }
                else
                {
                    invite._peasant -= _enemy * 3;
                }
            }
            else
            {
                invite._warrior -= _enemy;  
            }
            _currTimer = _maxTime;
            _enemy += Random.Range(10, 15);
        }
        _countEnemy.text = "Враг " + _enemy.ToString();
    }
}

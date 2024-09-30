using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Image clockTimer;
    [SerializeField] private float _maxTime = 10f;
    [SerializeField]private float _currTimer;
    [SerializeField] public float _wheat;
    [SerializeField] private float _plusWheat;
    [SerializeField] private TextMeshProUGUI _countWheat;
    private Invite invite;

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
            _currTimer = _maxTime;
            _wheat += _plusWheat + invite._peasant * invite._peasantWheat;
        }
        _countWheat.text = "ѕшеница " + _wheat.ToString();
    }
    public void Farmer(int count)
    {
        _wheat += count;
        _countWheat.text = "ѕшеница " + _wheat.ToString();
    }
  
}

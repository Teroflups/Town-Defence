using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Fead : MonoBehaviour
{
    [SerializeField] private Image clockTimer;
    [SerializeField] private float _currTimer;
    [SerializeField] private float _maxTime = 10f;
    [SerializeField] private int _food;
    Invite warriors;
    Timer timer;
    void Start()
    {
        warriors = GetComponent<Invite>();
        timer = GetComponent<Timer>();
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
            timer._wheat -= _food;
            if (_food < 0) 
            {
                warriors._warrior += _food;
                warriors._counterWarrior.text = warriors._warrior.ToString();
            }
        }
    }
}

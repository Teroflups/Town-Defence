using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Invite : MonoBehaviour
{
    [SerializeField] public float _warrior;
    [SerializeField] public TextMeshProUGUI _counterWarrior;
    [SerializeField] public TextMeshProUGUI _counterPeasant;
    [SerializeField] Button warriorButton;
    [SerializeField] Button peasantButton;
    private Timer wheat;
    [SerializeField] public float _peasant;
    [SerializeField] public float _peasantWheat;
    [SerializeField] private Image clockTimer;
    [SerializeField] private Image clockTimer2;
    [SerializeField] private float _maxTime = 10f;
    [SerializeField] private float _maxTime2 = 10f;
    [SerializeField] private float _currTimer;
    [SerializeField] private float _currTimer2;
    [SerializeField] int _priceOfFarmer;
    [SerializeField] int _priceOfWarrior;
    private bool _isPlusP = false;
    private bool _isPlusW = false;
    [SerializeField] private Button _buttonP;
    [SerializeField] private Button _buttonW;

    private bool _plusWarrior = false;
    private bool _plusPeasant = false;
    void Start()
    {
        wheat = GetComponent<Timer>();
        _currTimer = _maxTime;
        _currTimer2 = _maxTime2;
    }

    void Update()
    {
        AddWarrior();
        AddPeasant();
    }
    public void AddWarrior()
    {
        if (_currTimer >= 0 && _isPlusW)
        {
            _currTimer -= Time.deltaTime;
        }
        else if (_isPlusW && _currTimer <= 0)
        {
            _currTimer = _maxTime;
            _warrior++;
            _isPlusW = false;
            _buttonW.interactable = true;
        }
        _counterWarrior.text = "Воин " + _warrior.ToString();
        clockTimer.fillAmount = _currTimer / _maxTime;

    }
    public void AddPeasant()
    {

        if (_currTimer2 >= 0 && _isPlusP)
        {
            _currTimer2 -= Time.deltaTime;
        }
        else if(_isPlusP && _currTimer2 <= 0)
        {
            _currTimer2 = _maxTime2;
            _peasant++;
            _isPlusP = false;
            _buttonP.interactable = true;
        }
        _counterPeasant.text = "Крестьянин " + _peasant.ToString();
        clockTimer2.fillAmount = _currTimer2 / _maxTime2;
    }
    public void PlusP()
    {
        _isPlusP = true;
        _buttonP.interactable = false;
    }
    public void PlusW()
    {
        _isPlusW = true;
        _buttonW.interactable= false;
    }
    
}

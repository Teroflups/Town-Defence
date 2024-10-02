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
    [SerializeField] private float _maxTime = 10f;
    [SerializeField] private float _currTimer;
    [SerializeField] int _priceOfFarmer;
    [SerializeField] int _priceOfWarrior;

    private bool _plusWarrior = false;
    private bool _plusPeasant = false;
    void Start()
    {
        wheat = GetComponent<Timer>();
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
    }
    public void AddWarrior()
    {
        if(wheat._wheat - _priceOfWarrior >= 0)
        {
            if (_plusWarrior == true) return;
            StartCoroutine(WarriorDelay());
        }
      
    }
    public void addPeasant()
    {
        if (wheat._wheat - _priceOfFarmer  >= 0)
        {
            if(_plusPeasant == true) return;
            StartCoroutine(PeasantDelay());
        }
    }
    IEnumerator WarriorDelay()
    {
        _plusWarrior = true;
        warriorButton.interactable = false;
        yield return new WaitForSeconds(2);
        warriorButton.interactable = true;
        _plusWarrior = false;
        wheat.Farmer(-_priceOfWarrior);
        _warrior++;
        _counterWarrior.text = "Воин " + _warrior.ToString();
    }
    IEnumerator PeasantDelay()
    {
        _plusPeasant = true;
        peasantButton.interactable = false;
        yield return new WaitForSeconds(2);
        peasantButton.interactable= true;
        _plusPeasant = false;
        wheat.Farmer(-_priceOfFarmer);
        _peasant++;
        _counterPeasant.text = "Крестьянин " + _peasant.ToString();

    }
}

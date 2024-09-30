using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Invite : MonoBehaviour
{
    [SerializeField] public float _warrior;
    [SerializeField] public TextMeshProUGUI _counterWarrior;
    [SerializeField] public TextMeshProUGUI _counterPeasant;
    private Timer wheat;
    [SerializeField] public float _peasant;
    [SerializeField] public float _peasantWheat;
    void Start()
    {
        wheat = GetComponent<Timer>();
    }

    void Update()
    {
        
    }
    public void AddWarrior()
    {
        if(wheat._wheat > 0)
        {
            wheat.Farmer(-1);
            _warrior++;
            _counterWarrior.text = "Воин " + _warrior.ToString();
        }
      
    }
    public void addPeasant()
    {
        if (wheat._wheat > 0)
        {
            wheat.Farmer(-1);
            _peasant++;
            _counterPeasant.text = "Крестьянин " + _peasant.ToString();
        }
    }
}

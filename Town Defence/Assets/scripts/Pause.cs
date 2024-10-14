using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject _stopPanel;
    [SerializeField] private GameObject _stop;
    [SerializeField] private GameObject _play;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Stop()
    {
        Time.timeScale = 0;
        _stopPanel.SetActive(true);
        _play.SetActive(true);
        _stop.SetActive(false);
    }
    public void Play()
    {
        Time.timeScale = 1;
        _stopPanel.SetActive(false);
        _stop.SetActive(true);
        _play.SetActive(false);
    }
}

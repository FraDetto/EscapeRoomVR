using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame_On_Off : MonoBehaviour
{
    private ParticleSystem _particleSystem;
    private bool isOn = false;

    private void Awake()
    {
        _particleSystem = GetComponentInChildren<ParticleSystem>();
    }

    public void turnOnOff()
    {
        if (!isOn)
        {
            _particleSystem.Play();
            isOn = true;
        }
        else
        {
            _particleSystem.Stop();
            isOn = false;
        }
        
    }

    public bool getIsOn()
    {
        return isOn;
    }
}

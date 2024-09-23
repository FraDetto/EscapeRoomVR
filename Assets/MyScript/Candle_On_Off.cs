using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle_On_Off : MonoBehaviour
{
    public ParticleSystem _particleSystem;
    private bool isOn = false;
    private void Awake()
    {
        _particleSystem = GetComponentInChildren<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)//Deteach other che è flame
    {
        
        if (other.gameObject.layer==6 && other.gameObject.transform.GetComponent<Flame_On_Off>().getIsOn())
        {
            if (!isOn)
            {
                turnOnOff();
            }          
        }      
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

    public void offOnVelocity()
    {
        if (isOn)
        {
            turnOnOff();
        }

    }
        public bool getIsOn()
    {
        return isOn;
    }
}

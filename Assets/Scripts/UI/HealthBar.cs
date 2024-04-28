using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    public void UpdateHealthBar(int currentValue,int maxValue)
    {
        _slider.value = currentValue / maxValue;
    }
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthSlider : MonoBehaviour
{
    public static  HealthSlider instance;
    [SerializeField] Slider M_Slider;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        M_Slider = GetComponent<Slider>();
    }

    public void getSlider(float M_value)
    {
        M_Slider.value = M_value;
       // if (M_value <= 0) M_Slider.gameObject.SetActive(false);
    }
}

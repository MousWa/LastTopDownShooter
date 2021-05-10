using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

	public Slider slider;
	public Gradient gradient;
	public Image fill;

    private void Start()
    {
		slider.maxValue = 10;
		slider.value = 10;

		fill.color = gradient.Evaluate(1f);
	}
    public void SetHealth()
	{
		slider.value --;

		fill.color = gradient.Evaluate(slider.normalizedValue);
	}

}

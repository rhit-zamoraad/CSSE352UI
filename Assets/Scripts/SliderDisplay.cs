using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderValueDisplay : MonoBehaviour
{
    public Slider slider;
    public TMP_Text valueText;

    void Start()
    {
        slider.onValueChanged.AddListener(UpdateValue);
        UpdateValue(slider.value);
    }

    void UpdateValue(float value)
    {
        valueText.text = value.ToString("0");
    }
}

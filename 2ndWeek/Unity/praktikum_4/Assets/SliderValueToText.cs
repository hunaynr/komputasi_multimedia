using UnityEngine.UI;
using System.Collections;
using UnityEngine;


public class SliderValueToText : MonoBehaviour
{
    public Slider sliderUI;
    private Text textSliderValue;
    // Start is called before the first frame update
    void Start()
    {
        textSliderValue = GetComponent<Text>();
        ShowSliderValue();
    }

    // Update is called once per frame
    public void ShowSliderValue()
    {
        string SliderMessage = "Slider value = " +
        sliderUI.value;
        textSliderValue.text = SliderMessage;
    }
}
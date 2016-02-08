using UnityEngine;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour {

    public Button button;
    public Slider slider;
    public Toggle toggle;

    private string _buttonKey = "VALUE_BUTTON";
    private string _toggleKey = "VALUE_TOGGLE";
    private string _sliderKey = "VALUE_SLIDER";

	// Use this for initialization
	void Start ()
    {
        

        //Load the button status
        if (PlayerPrefs.HasKey(_buttonKey))
        {
            Text buttonText = button.GetComponentInChildren<Text>();
            buttonText.text = PlayerPrefs.GetString(_buttonKey);
        }
        else
        {
            
            SaveButtonValue();
        }

        //Load the toggle status
        if (PlayerPrefs.HasKey(_toggleKey))
        {
            int isToggled = PlayerPrefs.GetInt(_toggleKey);

            if (isToggled == 1)
                toggle.isOn = true;
            else
                toggle.isOn = false;
        }
        else
        {
            SaveToggleStatus();
        }

        //Load the slider's value
        if (PlayerPrefs.HasKey(_sliderKey))
        {
            slider.value = PlayerPrefs.GetFloat(_sliderKey);
        }
        else
        {
            SaveSliderValue();
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    //Save/update the stored value for the button
    public void SaveButtonValue()
    {
        Text buttonText = button.GetComponentInChildren<Text>();
        PlayerPrefs.SetString(_buttonKey, buttonText.text);
        PlayerPrefs.Save();
    }

    //Save/update the stored value for the toggle
    public void SaveToggleStatus()
    {
        int isToggled;

        if (toggle.isOn)
            isToggled = 1;
        else
            isToggled = 0;

        PlayerPrefs.SetInt(_toggleKey, isToggled);
        PlayerPrefs.Save();
    }

    //Save/update the stored value for the slider
    public void SaveSliderValue()
    {
        PlayerPrefs.SetFloat(_sliderKey, slider.value);
        PlayerPrefs.Save();
    }
}

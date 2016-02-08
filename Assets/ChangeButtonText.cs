using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonText : MonoBehaviour {

    private float _isClicked;
    public Button button;

	// Use this for initialization
	void Start () {
        
        Text buttonText = button.GetComponentInChildren<Text>();
        if (buttonText.text == "Clicky")
        {           
            _isClicked = 1.0f;
        }
        else if (buttonText.text == "Click")
        {
            _isClicked = 0.0f;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeText()
    {
        if (button)
        {
            if (_isClicked == 0.0f)
            {
                Text buttonText = button.GetComponentInChildren<Text>();
                buttonText.text = "Clicky";
                _isClicked = 1.0f;
            }
            else if(_isClicked == 1.0f)
            {
                Text buttonText = button.GetComponentInChildren<Text>();
                buttonText.text = "Click";
                _isClicked = 0.0f;
            }
        }
    }
}

using TMPro;
using UnityEngine;

public class PasswordDisplay : MonoBehaviour
{
    public TMP_InputField inputField; 
    public TMP_Text displayText; 

    void Start()
    {
        DisplayValue();
    }

    public void DisplayValue()
    {
        displayText.text = $"Your password is: {inputField.text}";
    }
}

using TMPro;
using UnityEngine;

public class InputDisplay : MonoBehaviour
{
    public TMP_InputField inputField; 
    public TMP_Text displayText; 

    void Start()
    {
        DisplayValue();
    }

    public void DisplayValue()
    {
        displayText.text = $"Hello {inputField.text}!";
    }
}

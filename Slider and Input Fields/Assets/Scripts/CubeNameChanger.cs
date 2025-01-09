using TMPro;
using UnityEngine;

public class CubeNameChanger : MonoBehaviour
{
    public TMP_Text nameDisplayText; 
    public TMP_InputField nameInputField; 

    public void UpdateName()
    {
        string newName = nameInputField.text; 
        if (!string.IsNullOrWhiteSpace(newName))
        { 
            nameDisplayText.text = $"Cube Name: {newName}"; 
        }
    }
}

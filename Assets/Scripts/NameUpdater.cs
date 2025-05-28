using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameUpdater : MonoBehaviour
{
    public GameObject cube;
    public TMP_Text nameDisplayText;
    public TMP_InputField nameInputField;
    public Button changeNameButton;

    private void Start()
    {
        changeNameButton.onClick.AddListener(UpdateCubeName);
    }
    void UpdateCubeName()
    {
        string newName = nameInputField.text;
        if(!string.IsNullOrWhiteSpace(newName))
        {
            nameDisplayText.text = $"Cube Name: {newName}";
            cube.name = newName;
        }
        else
        {
            Debug.LogWarning("Name input is empty");
        }
    }
}

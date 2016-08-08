using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score: MonoBehaviour
{
    Text textComponent;

    void ChangeText(string score) {
        textComponent = GetComponent<Text>();
        textComponent.text = score;
    }
}

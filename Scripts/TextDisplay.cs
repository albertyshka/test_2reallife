using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextDisplay : MonoBehaviour
{
    public float showTime = 0.05f;

    private Text text;
    private IEnumerator textCoroutine;
    
    private void Start()
    {
        text = transform.GetComponent<Text>();
    }

    public void startShowingText(string newText)
    {
        if (textCoroutine != null)
            StopCoroutine(textCoroutine);

        textCoroutine = ShowText(newText);
        StartCoroutine(textCoroutine);
    }

    IEnumerator ShowText(string newText)
    {
        text.text = "";
        foreach(char ch in newText)
        {
            text.text += ch;
            yield return new WaitForSeconds(showTime);
        }
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public TextMeshProUGUI dialogText;
    public GameObject dialogBox;

    public string[] dialogLines;

    public int currentLine;

    // Start is called before the first frame update
    void Start()
    {
        dialogText.text = dialogLines[currentLine];
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogBox.activeInHierarchy)
        {
            if(Input.GetButtonUp("Fire2"))
            {
                currentLine = currentLine + 1;

                if(currentLine >= dialogLines.Length)
                {
                    dialogBox.SetActive(false);
                }
                else
                {
                    dialogText.text = dialogLines[currentLine];
                }

            }
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameText : MonoBehaviour
{
    public static NameText Instance;
    public string nameText = "Default Name";
    private string keyPressed;
    private bool firstKeyPress = false;
    TextMeshPro tmPro;
    
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        tmPro = gameObject.GetComponent<TextMeshPro>();
        
    }
    private void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            
            if (Input.inputString != null)
            {
                if (!firstKeyPress)
                {
                    firstKeyPress = true;
                    nameText = "";
                }
                nameText += Input.inputString;
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                nameText = "";
            }
            else
            {
                return;
            }
            tmPro.SetText(nameText);
        }
        
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{

    public Text pressedText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PressMe()
    {
        Debug.Log("I'm pressed");
        pressedText.text = "I've been pressed again";
    }

    public void PressAnother()
    {
        Debug.Log("Another is pressed");
        pressedText.text = "Another's been pressed";
    }
}

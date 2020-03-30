using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RosterItem : MonoBehaviour
{
    public Player leftPerson, rightPerson;
    public Image leftPersonImage, rightPersonImage;
    public Text leftPersonText, rightPersonText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayValues();
    }

    void DisplayValues()
    {
        leftPersonText.text = leftPerson.GetPlayerName();
        rightPersonText.text = rightPerson.GetPlayerName();
    }
}

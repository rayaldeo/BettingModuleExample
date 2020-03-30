using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RosterItem : MonoBehaviour
{
    public Player leftPlayer, rightPlayer;
    public Image leftPlayerImage, rightPlayerImage;
    public Text leftPlayerText, rightPlayerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(leftPlayer.GetPlayerName());
        if(leftPlayer!=null && rightPlayer != null) { DisplayValues(); }
       
    }

    void DisplayValues()
    {
        leftPlayerText.text = leftPlayer.GetPlayerName();
        rightPlayerText.text = rightPlayer.GetPlayerName();
    }

    public void SetLeftPlayer(Player player) 
    {
        this.leftPlayer = player;
    }

    public void SetRightPlayer(Player player)
    {
        this.rightPlayer = player;
    }
}

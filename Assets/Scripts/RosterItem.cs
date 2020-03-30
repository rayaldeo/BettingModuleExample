using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RosterItem : MonoBehaviour
{
    public Player leftPlayer, rightPlayer;
    public Image leftPlayerImage, rightPlayerImage;
    public Text leftPlayerText, rightPlayerText;
    GameObject leftPlayerSprite, rightPlayerSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void DisplayValues()
    {

        leftPlayerText.text = leftPlayer.GetPlayerName();
        rightPlayerText.text = rightPlayer.GetPlayerName();
        //this.leftPlayerImage = leftPlayerSprite.GetComponent<Image>();
        //this.rightPlayerImage = rightPlayerSprite.GetComponent<Image>();
    }

    public void SetLeftPlayer(Player player,GameObject image) 
    {
        Debug.Log("Setting Left Player");
        this.leftPlayer = player;
        Debug.Log("Setting Left Player Image");
        this.leftPlayerSprite = image;
    }

    public void SetRightPlayer(Player player,GameObject image)
    {
        Debug.Log("Setting Right Player");
        this.rightPlayer = player;
        this.rightPlayerSprite = image;
    }
}

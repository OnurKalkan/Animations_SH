using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform playerOnePos, playerTwoPos;

    // Update is called once per frame
    void Update()
    {
        if(playerOnePos.position.x < playerTwoPos.position.x)
        {
            //player one left
            playerOnePos.localScale = new Vector3(10, 10, 10);
            playerOnePos.gameObject.GetComponent<Warrior>().onLeft = true;
            playerOnePos.gameObject.GetComponent<Warrior>().onRight = false;
            //
            playerTwoPos.localScale = new Vector3(-10, 10, 10);
            playerTwoPos.gameObject.GetComponent<Warrior>().onLeft = false;
            playerTwoPos.gameObject.GetComponent<Warrior>().onRight = true;
        }
        else
        {
            playerOnePos.localScale = new Vector3(-10, 10, 10);
            playerOnePos.gameObject.GetComponent<Warrior>().onLeft = false;
            playerOnePos.gameObject.GetComponent<Warrior>().onRight = true;
            //
            playerTwoPos.gameObject.GetComponent<Warrior>().onLeft = true;
            playerTwoPos.gameObject.GetComponent<Warrior>().onRight = false;
            playerTwoPos.localScale = new Vector3(10, 10, 10);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearAttack : MonoBehaviour
{
    public bool enemyNear;
    public bool playerOne, playerTwo;
    public GameObject enemy;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (playerOne && collision.CompareTag("PlayerTwo"))
        {
            enemyNear = true;
        }
        else if (playerTwo && collision.CompareTag("PlayerOne"))
        {
            enemyNear = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (playerOne && collision.CompareTag("PlayerTwo"))
        {
            enemyNear = false;
        }
        else if (playerTwo && collision.CompareTag("PlayerOne"))
        {
            enemyNear = false;
        }
    }
}

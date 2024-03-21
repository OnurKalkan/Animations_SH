using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public int fireSpeed = 10;
    public string enemyTag;

    // Update is called once per frame
    void Update()
    {
        if(enemyTag == "PlayerOne")
        {
            if(GameObject.FindGameObjectWithTag(enemyTag).GetComponent<Warrior>().onLeft)
                transform.Translate(Vector3.left * Time.deltaTime * fireSpeed);
            else if (GameObject.FindGameObjectWithTag(enemyTag).GetComponent<Warrior>().onRight)
                transform.Translate(Vector3.right * Time.deltaTime * fireSpeed);
        }            
        else if(enemyTag == "PlayerTwo")
        {
            if (GameObject.FindGameObjectWithTag(enemyTag).GetComponent<Warrior>().onLeft)
                transform.Translate(Vector3.left * Time.deltaTime * fireSpeed);
            else if (GameObject.FindGameObjectWithTag(enemyTag).GetComponent<Warrior>().onRight)
                transform.Translate(Vector3.right * Time.deltaTime * fireSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(enemyTag))
        {
            if(collision.gameObject.GetComponent<Warrior>().health > 0)
            {
                if (collision.gameObject.GetComponent<Warrior>().onBlock)
                {
                    collision.gameObject.GetComponent<Warrior>().health -= 2;
                }
                else
                {
                    collision.gameObject.GetComponent<Warrior>().health -= 15;
                    collision.GetComponent<Animator>().SetTrigger("Hurt");
                }
                if(collision.gameObject.GetComponent<Warrior>().health <= 0)
                {
                    collision.GetComponent<Animator>().SetBool("Death", true);
                    this.gameObject.SetActive(false);
                }                
            }
            
        }
        if (collision.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }
    }
}

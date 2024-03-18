using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public int fireSpeed = 10;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * fireSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerTwo"))
        {
            collision.GetComponent<Animator>().SetBool("Death", true);
            this.gameObject.SetActive(false);
        }
    }
}

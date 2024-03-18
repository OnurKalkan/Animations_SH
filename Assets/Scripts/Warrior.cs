using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour
{
    public Animator animator;
    public int runSpeed = 10, jumpForce = 100;
    public Rigidbody2D rb;
    public GameObject sampleFireBall;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Run", true);
            animator.SetBool("Idle", false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("Jump");
            rb.AddForce(Vector2.up * jumpForce);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack");
        }
        if (Input.anyKey == false)
        {
            animator.SetBool("Run", false);
            animator.SetBool("Idle", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * runSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * runSpeed);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Invoke(nameof(Attack), 0.5f);
        }
    }

    void Attack()
    {
        GameObject newFireBall = Instantiate(sampleFireBall, transform.position, Quaternion.identity);
        newFireBall.SetActive(true);
    }
}

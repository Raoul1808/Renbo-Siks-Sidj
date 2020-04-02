using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public GameObject florSprite;
    public GameObject terrorist;
    public Transform playerPos;
    private Vector3 tempPos;
    public float vel = 0.1f;
    private bool canJump = false;
    public int jumpTime;

    void Start()
    {
        //tempPos = new Vector3(0, 0, 0);
        jumpTime = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerPos.position.y <= -5)
            SceneManager.LoadScene("Cheat");

        //if (!canJump)
        //    tempPos.y -= vel;
        if (Input.GetKey(KeyCode.LeftArrow))
            tempPos.x -= vel;
        if (Input.GetKey(KeyCode.RightArrow))
            tempPos.x += vel;
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    if (canJump)
        //    {
        //        if (!(jumpTime == 0))
        //        {
        //            jumpTime--;
        //            tempPos.y += vel;
        //        }
        //        else
        //        {
        //            jumpTime = 50;
        //            canJump = false;
        //        }
        //    }
        //}
        //if (Input.GetKeyUp(KeyCode.Space))
        //    canJump = false;
        //playerPos.position = tempPos;
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        //if (col.gameObject == florSprite)
        //{
        //    canJump = true;
        //    tempPos.y = -4.0f;
        //    playerPos.position = tempPos;
        //}
        ///*else*/ if (col.gameObject == terrorist)
        //    SceneManager.LoadScene("Ded");
    }
}


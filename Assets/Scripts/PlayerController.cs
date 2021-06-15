using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator playerAnim;
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            playerAnim.SetBool("Idle",false);
            playerAnim.SetBool("Attack",true);
        }else if (Input.GetKeyDown(KeyCode.I))
        {
            playerAnim.SetBool("Idle",true);
        }else if (Input.GetKey(KeyCode.R))
        {
            playerAnim.SetBool("Idle",false);
            playerAnim.SetBool("Run",true);
        }
        else
        {
            playerAnim.SetBool("Run",false);
            playerAnim.SetBool("Attack",false);
        }
    }
}

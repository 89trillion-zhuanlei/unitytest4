using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator playerAnim;
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerAnim.SetTrigger("Attack");
        }else if (Input.GetKeyDown(KeyCode.I))
        {
            playerAnim.SetTrigger("Idle");
        }else if (Input.GetKeyDown(KeyCode.R))
        {
            playerAnim.SetTrigger("Run");
        }
    }
}

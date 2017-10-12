using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    #region variable
    private CharacterController Player;
    private Vector3 Velocity;
    #endregion
    #region Event
    // Use this for initialization
    void Start()
    {
        Player = GetComponent<CharacterController>();
        Velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.isGrounded)
        {
            Velocity.x = Input.GetAxis("Horizontal");
            Velocity.y = 0;
            Velocity.z = Input.GetAxis("Vertical");
        }
        Velocity.y += Physics.gravity.y * Time.deltaTime;
        Player.Move(Velocity * Time.deltaTime);

    }
    #endregion

}

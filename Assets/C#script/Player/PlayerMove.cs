﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    #region variable
    //private CharacterController Player;
    //private Vector3 Velocity;

    [SerializeField]
    private Joystick _joystick=null;

    //移動速度
    private const float SPEED = 0.1f;
    State state;
    #endregion
    #region Event
    // Use this for initialization
    void Start()
    {
        //Player = GetComponent<CharacterController>();
        //Velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += _joystick.Position.x * SPEED;
        pos.z += _joystick.Position.y * SPEED;
        
        transform.position = pos;


    }
    #endregion

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    #region variable
    public static Player instance = null;
    [SerializeField]
    private Joystick joystick = null;
    //playerの移動速度
    private const float MoveSpeed = 0.1f;
    #endregion

    #region Event
    //初期化（変数）
    private void Awake()
    {
        Player.instance = this;
    }

    public void Move()
    {
        Vector3 pos = transform.position;
        pos.x += joystick.Position.x * MoveSpeed;
        pos.z += joystick.Position.y * MoveSpeed;

        transform.position = pos;

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //移動処理
        Move();

    }

    #endregion


}

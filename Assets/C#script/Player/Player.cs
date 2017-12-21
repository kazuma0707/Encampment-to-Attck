using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    #region variable
    public static Player instance = null;
    [SerializeField]//ジョイスティック
    private Joystick joystick = null;
    //playerの移動速度
    private const float MoveSpeed = 0.1f;
    Vector3 pos;

    #endregion

    #region Event
    //初期化（変数）
    private void Awake()
    {
        Player.instance = this;
    }
    //Playerの移動処理
    public void Move()
    {
         pos = transform.position;
        pos.x += joystick.Position.x * MoveSpeed;
        pos.z += joystick.Position.y * MoveSpeed;

        transform.position = pos;
    }
    //Playerの座標取得
    public Vector3 GetPos(){ return pos;  }


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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    #region variable
    public static Player instance = null;//Playerのインスタンス
    [SerializeField]//ジョイスティック
    private Joystick joystick = null;
    private const float MoveSpeed = 0.1f;//playerの移動速度
    Vector3 Playerpos;

    public Slider HpSlider;
    public readonly int maxHP = 100; //体力の最大値
    public int HP;//体力


    #endregion

    #region Event
    //初期化（変数）
    private void Awake()
    {
        Player.instance = this;
    }
    

    // Use this for initialization
    void Start()
    {
        HP = maxHP;
        HpSlider.value = 100;


    }

    // Update is called once per frame
    void Update()
    {

        //移動処理
        Move();


    }
    //Playerの移動処理
    public void Move()
    {

        Playerpos = transform.position;
        Playerpos.x += joystick.Position.x * MoveSpeed;
        Playerpos.z += joystick.Position.y * MoveSpeed;

        transform.position = Playerpos;
    }
    //Playerの座標取得
    public Vector3 GetPos() { return Playerpos; }

    #endregion


}

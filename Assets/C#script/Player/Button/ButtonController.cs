using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : Button {
    #region variable

    public Image BlImage;//シールドの画像
    public Image AtkImage;//攻撃の画像

    //ImageControllのオブジェクト
    private ImageControll image1;
    private ImageControll image2;

    ButtonObjectName ButtonName;//ボタンのオブジェクト名
    [SerializeField]
    private GameObject Shield;//シールドのプレファブ
    [SerializeField]
    private GameObject Attck;//攻撃オブジェのプレファブ
    Vector3 Playerpos;//Playerの座標

    private void Awake()
    {
        image1 = new ImageControll();
        image2 = new ImageControll();
    }
    #endregion
    private void Start()
    {
        ButtonName = gameObject.AddComponent<ButtonObjectName>();

        image1.SetImage(BlImage);
        image2.SetImage(AtkImage);
    }

    private void Update()
    {
        Playerpos = Player.instance.GetPos();//Playerの座標を取得

        //アップデート
        image1.puchButtonUpdate();
        image2.puchButtonUpdate();

    }

    protected override void OnClick(string objectName)
    {
  
        if (!image1.GetpuchButton()&&ButtonName.GetObjName(ButtonObjectName.BUTTON_ID.SiledButton).Equals(objectName))
        {
            this.SiledButtonClick();
            image1.SetpuchButton(true);
        }
        else if (!image2.GetpuchButton()&&ButtonName.GetObjName(ButtonObjectName.BUTTON_ID.AttckButton).Equals(objectName))
        {
            this.AttckButtonClick();
            image2.SetpuchButton(true);

        }
        //else if (!puchButtonFlag3&&ButtonName.GetObjName(ButtonObjectName.BUTTON_ID.MetastasisButton).Equals(objectName))
        //{
        //    this.MetastasisButtonClick();

        //}

    }

    private void SiledButtonClick()
    {
        Debug.Log("SiledButton Click");
        Instantiate(Shield, new Vector3(Playerpos.x, Playerpos.y, Playerpos.z + 5), new Quaternion(0, 0, 0, 0));
        image1.SetImage1fillAmount(0.0f);

    }
    private void AttckButtonClick()
    {
        Debug.Log("AttckButtonClick");
        Instantiate(Attck, new Vector3(Playerpos.x, Playerpos.y, Playerpos.z + 5), new Quaternion(0, 0, 0, 0));
        image2.SetImage1fillAmount(0.0f);


    }
    //private void MetastasisButtonClick()
    //{
    //    Debug.Log("MetastasisButtonClick");
    //}

}

class ImageControll
{
    private Image ButtonImage;//ボタンの画像

    bool puchButtonFlag = false;//ボタン押し出し許可フラグ

    private Vector3 allowTime = new Vector3(0, 0, 600);//マックス時間
    private float NowTime;//現在の時間

    //アップデート
    public void puchButtonUpdate()
    {
        //ボタンが押されたら
        if (puchButtonFlag)
        {
            NowTime += 1;
            ButtonImage.fillAmount += Time.deltaTime * 0.1f;//約10秒までの計算

            //10以上経ったら
            if (NowTime > allowTime.z)
            {
                Debug.Log("TimeOk");

                //初期化
                puchButtonFlag = false;
                NowTime = 0;
            }
        }
    }
    //アクセッサ
    public void SetImage(Image image){ ButtonImage = image; }
    public void SetImage1fillAmount(float time){  ButtonImage.fillAmount = time;}
    public bool GetpuchButton() { return puchButtonFlag; }
    public void SetpuchButton(bool flag) {  puchButtonFlag=flag; }
    
}

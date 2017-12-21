//__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/
//! @file   ButtonObjectName
//! @brief ボタンのオブジェクト名を管理するクラス
//!
//! @date   日付		2017/10/26
//!
//! @author 制作者名	森一真
//__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/__/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonObjectName : MonoBehaviour {
    string ButtonName;//オブジェクトの名前を返す変数

    //ButtonのID
    public enum BUTTON_ID
    {
        SiledButton,
        AttckButton,
        MetastasisButton
    }
    /// <summary>
    /// ボタンのオブジェクト名を返す
    /// </summary>
    /// <param name="ID">ButtonのID</param>
    /// <returns></returns>
    public string GetObjName(BUTTON_ID ID)
    {
        switch (ID)
        {
            case BUTTON_ID.SiledButton:
                ButtonName = "SiledButton";
                break;
            case BUTTON_ID.AttckButton:
                ButtonName = "AttckButton";
                break;
            case BUTTON_ID.MetastasisButton:
                ButtonName = "MetastasisButton";
                break;
            default:
                return null;
        }
        return ButtonName;
    }

}

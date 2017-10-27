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
    string ButtonName;

    //ButtonのID
    public enum BUTTON_ID
    {
        SiledButton,
        AttckButton,
        MetastasisButton
    }
   
    private void Start()
    {
    }
    /// <summary>
    /// ボタンのオブジェクト名を返す
    /// </summary>
    /// <param name="ID">ButtonのID</param>
    /// <returns></returns>
    public string SetObjectName(BUTTON_ID ID)
    {
        //if (ID == BUTTON_ID.SiledButton) { return "SiledButton"; }
        //if (ID == BUTTON_ID.AttckButton) { return "AttckButton"; }
        //if (ID == BUTTON_ID.MetastasisButton) { return "MetastasisButton"; }
        //return null;
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

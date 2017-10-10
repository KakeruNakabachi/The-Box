using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    /* constで定数を表す */
    public const int WALL_FRONT = 1; //前
    public const int WALL_RIGHT = 2; //右
    public const int WALL_BACK = 3; //後
    public const int WALL_LEFT = 4; //左

    public GameObject panelWalls;

    public GameObject buttonMessage;
    public GameObject buttonMessageText;

    private int wallNo; //現在の向いている方向

    // Use this for initialization
    void Start ()
    {
        wallNo = WALL_FRONT;
	}

	// Update is called once per frame
	void Update ()
    {

    }

    public void PushButtonMemo ()
    {
        DisplayMessage("エッフェル塔と書いてある");
    }

    public void PushButtonMessage ()
    {
        buttonMessage.SetActive(false); //メッセージを消す
    }

    public void PushButtonRight ()
    {
        wallNo++;

        //WALL_LEFTより右に行こうとした場合WALL_FRONTに戻す
        if (wallNo > WALL_LEFT)
        {
            wallNo = WALL_FRONT;
        }
        DisplayWall();
    }

    public void PushButtonLeft ()
    {
        wallNo--;

        if (wallNo < WALL_FRONT)
        {
            wallNo = WALL_LEFT;
        }
        DisplayWall();
    }

    void DisplayMessage(string mes)
    {
        buttonMessage.SetActive(true);
        buttonMessageText.GetComponent<Text>().text = mes;
    }

    void DisplayWall()
    {
        switch (wallNo)
        {
            case WALL_FRONT:
                panelWalls.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
                break;
            case WALL_RIGHT:
                panelWalls.transform.localPosition = new Vector3(-1000.0f, 0.0f, 0.0f);
                break;
            case WALL_BACK:
                panelWalls.transform.localPosition = new Vector3(-2000.0f, 0.0f, 0.0f);
                break;
            case WALL_LEFT:
                panelWalls.transform.localPosition = new Vector3(-3000.0f, 0.0f, 0.0f);
                break;
        }
    }
}

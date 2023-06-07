using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMgr : MonoBehaviour
{
   public void ButtonClick(string type)
	{
		switch (type)
		{
			case "Start":
				SceneManager.LoadScene("2_GameScene");
				Debug.Log("start");
				break;
			case "Continue":
				// 이어서하기
				break;
			case "Creadit":
				// 만든사람 출처
				break;
			
			default:
				break;
		}

	}
}

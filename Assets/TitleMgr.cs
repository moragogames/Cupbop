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
				// �̾�ϱ�
				break;
			case "Creadit":
				// ������ ��ó
				break;
			
			default:
				break;
		}

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour {

	private Dictionary<string, Popup> popupDict = new Dictionary<string, Popup>{};

	void Awake()
	{
		Popup[] popupArray = GetComponentsInChildren<Popup>(true);

		foreach (Popup popup in popupArray)
		{
			popupDict.Add(popup.gameObject.name, popup);
			popup.gameObject.SetActive(false);
		}
	}

	public void OpenPopup(string name, Popup.PopupData data = null)
	{
		popupDict[name].gameObject.SetActive(true);
		popupDict[name].data = data;
	}

	public void ClosePopup(string name)
	{
		popupDict[name].gameObject.SetActive(false);
	}
}

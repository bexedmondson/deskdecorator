using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeskManager : MonoBehaviour {

	private Location[] locationList;

	private Location selected = null;

	void Awake()
	{
		locationList = GetComponentsInChildren<Location>();
	}

	public void OnLocationClicked(Location source)
	{
		Game.ScreenManager.ClosePopup("SelectorPopup");

		if (source == selected)
		{
			source.Deselect();
			selected = null;
		}
		else
		{
			foreach (Location location in locationList)
			{
				if (location == selected)
					location.Deselect();
				else if (location == source)
					location.Select();
			}

			SelectorPopup.SelectorPopupData data = new SelectorPopup.SelectorPopupData();
			data.source = source;

			Game.ScreenManager.OpenPopup("SelectorPopup", data);

			selected = source;
		}
	}
}

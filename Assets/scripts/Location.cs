using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Location : Button {

	[SerializeField]
	private Button button;

	private bool isSelected = false;

	public override void Select()
	{
		if (!isSelected)
		{
			isSelected = true;
			image.color = Color.blue;
		}
	}

	public void Deselect()
	{
		if (isSelected)
		{
			isSelected = false;
			image.color = Color.white;
			Game.ScreenManager.ClosePopup("SelectorPopup");
		}
	}

	public void SetDecoration(Decoration dec)
	{
		button.image.sprite = dec.sprite;
	}
}

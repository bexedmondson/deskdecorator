using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DecorationListItem : MonoBehaviour {

	[SerializeField]
	private Text itemName;

	public Decoration decoration;

	private Action<DecorationListItem> ClickAction;

	public void SetDecoration(Decoration dec)
	{
		decoration = dec;
		itemName.text = decoration.ToString();
	}

	public void SetAction(Action<DecorationListItem> action)
	{
		ClickAction = action;
	}

	public void OnClick()
	{
		ClickAction(this);
	}
}

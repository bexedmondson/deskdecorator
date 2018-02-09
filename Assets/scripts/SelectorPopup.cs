using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorPopup : Popup {

	public class SelectorPopupData : Popup.PopupData
	{
		public Location source;
	}

	[SerializeField]
	private GameObject scroller;

	[SerializeField]
	private GameObject listItemPrefab;

	public new SelectorPopupData data;

	public void OnEnable()
	{
		foreach (Decoration dec in Game.DecorationManager.decorationList)
		{
			if (!dec.isPlaced)
			{
				GameObject item = Instantiate(listItemPrefab);
				item.transform.SetParent(scroller.transform);

				DecorationListItem listItem = item.GetComponent<DecorationListItem>();
				listItem.SetDecoration(dec);
				listItem.SetAction(OnDecorationSelected);
			}
		}
	}

	public void OnDecorationSelected(DecorationListItem item)
	{
		data.source.SetDecoration(item.decoration);
	}
}

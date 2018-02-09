using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	private static Game instance = null;

	[SerializeField]
	private ScreenManager m_screenManager;

	[SerializeField]
	private DecorationManager m_decorationManager;

	void Awake()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);    

		DontDestroyOnLoad (gameObject);
	}

	public Game Get { get { return instance; } }

	public static DecorationManager DecorationManager { get { return instance.m_decorationManager; } }

	public static ScreenManager ScreenManager { get { return instance.m_screenManager; } }
}

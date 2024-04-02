﻿using UnityEngine;

namespace AutoFish
{
	public class Loader
	{
		/// <summary>
		/// This method is run by Winch to initialize your mod
		/// </summary>
		public static void Initialize()
		{
			var gameObject = new GameObject(nameof(AutoFish));
			gameObject.AddComponent<AutoFish>();
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
}
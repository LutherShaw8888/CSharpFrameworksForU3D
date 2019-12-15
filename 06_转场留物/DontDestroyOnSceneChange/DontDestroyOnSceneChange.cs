using System.Runtime.CompilerServices;
/**********************************************************************
 *	Copyright (C) 2019-2020
 * 	File Name:	DontDestroyOnSceneChange.cs
 *	Author:	Luther Shaw
 **********************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LUTHER {
	/// <summary>
	/// 单例模式保留该脚本所在物体
	/// </summary>
	public class DontDestroyOnSceneChange : MonoBehaviour {
		public static DontDestroyOnSceneChange dontDestroyInstance = null;
		void Awake () {
			if (dontDestroyInstance != null) {
				Destroy (gameObject);
				return;
			}
			dontDestroyInstance = this;
			DontDestroyOnLoad (gameObject);
		}
	}
}
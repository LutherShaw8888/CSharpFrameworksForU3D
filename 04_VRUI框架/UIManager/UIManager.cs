/**********************************************************************
 *	Copyright (C) 2019-2020
 * 	File Name:	UIManager.cs
 *	Author:	Luther Shaw
 **********************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LUTHER {
	public class UIManager : MonoSingleton<UIManager> {
		private Dictionary<string, UIBaseWindow> uiManagerDic;
		public T GetWindow<T> () where T : class {
			string key = typeof (T).Name;
			return uiManagerDic[key] as T;
		}
		/// <summary>
		/// 通过基类单例的Init方法，为字典赋值。
		/// </summary>
		public override void Init () {
			uiManagerDic = new Dictionary<string, UIBaseWindow> ();
			UIBaseWindow[] uiBaseWindows = FindObjectsOfType<UIBaseWindow> ();
			for (int i = 0; i < uiBaseWindows.Length; i++) {
				uiBaseWindows[i].SetWindowsVisibleDelay (false);
				uiManagerDic.Add (uiBaseWindows[i].GetType ().Name, uiBaseWindows[i]);
			}
		}
	}
}
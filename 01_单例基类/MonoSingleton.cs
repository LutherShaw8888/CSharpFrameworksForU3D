/**********************************************************************
 *	Copyright (C) 2019-2020
 * 	File Name:	MonoSingleton.cs
 *	Author:	Luther Shaw
 **********************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T> {
	private static T instance;
	public static T MonoInstance {
		get {
			if (instance == null) {
				instance = FindObjectOfType<T> ();
				if (instance == null) {
					new GameObject ("MonoSingleton_" + typeof (T).Name).AddComponent<T> ();
				}
			} else {
				instance.Init ();
			}
			return instance;
		}
	}
	void Awake () {
		instance = this as T;
		instance.Init ();
	}
	public virtual void Init () { }
}
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
	/// <summary>
	/// 可在Unity3D生命周期任何一处方法中调用，包括Awake方法。
	/// </summary>
	/// <value></value>
	public static T MonoInstance {
		get {
			if (instance == null) {
				instance = FindObjectOfType<T> ();
				if (instance == null) {
					new GameObject ("MonoSingleton_" + typeof (T).Name).AddComponent<T> ();//找不到物体时，实例化一个物体，并挂载单例脚本。
				}
			} else {
				instance.Init ();
			}
			return instance;
		}
	}
	/// <summary>
	/// 只能在Awake方法之后调用
	/// </summary>
	void Awake () {
		instance = this as T;
		instance.Init ();
	}
	/// <summary>
	/// 基类提供一个初始化方法
	/// </summary>
	public virtual void Init () { }
}
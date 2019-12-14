/**********************************************************************
 *	Copyright (C) 2019-2020
 * 	File Name:	GameController.cs
 *	Author:	Luther Shaw
 **********************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using LUTHER;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	void Start () {
		UIManager instance=UIManager.Instance;
		instance.GetWindow<UIMainWindow> ().SetWindowsVisibleDelay (true);
	}

	void Update () {

	}
}
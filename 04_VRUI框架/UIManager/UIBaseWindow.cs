/**********************************************************************
 *	Copyright (C) 2019-2020
 * 	File Name:	UIBaseWindow.cs
 *	Author:	Luther Shaw
 **********************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRTK;

namespace LUTHER {
	public class UIBaseWindow : MonoBehaviour {
		private CanvasGroup canvasGroup;
		private VRTK_UICanvas vRTK_UICanvas;

		void Awake () {
			canvasGroup = GetComponent<CanvasGroup> ();
		}
		public void SetWindowsVisibleDelay (bool state, int delayTime = 0) {
			StartCoroutine (SetVisibleDelay (state, delayTime));
		}
		private IEnumerator SetVisibleDelay (bool state, int delayTime = 0) {
			yield return new WaitForSeconds (delayTime);
			canvasGroup.alpha = state?1 : 0;
		}
	}
}
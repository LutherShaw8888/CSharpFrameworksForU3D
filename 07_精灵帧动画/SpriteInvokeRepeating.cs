/**********************************************************************
 *	Copyright (C) 2019-2020
 * 	File Name:	SpriteInvokeRepeating.cs
 *	Author:	Luther Shaw
 **********************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LUTHER {
	public class SpriteInvokeRepeating : MonoBehaviour {
		[Range (1, 10)]
		public int maxNum = 10;
		private int gifIndex = 0;
		void Start () {
			InvokeRepeating ("SpriteAnimate", 0, 0.5f); //前端修改时间间隔无效，必须在这里修改。
		}
		private void SpriteAnimate () {
			Debug.Log (gifIndex + "--------" + DateTime.Now.Second); //do something like change sprites' index.
			gifIndex += 1;
			if (gifIndex > maxNum) gifIndex = 0;
		}
	}
}
/**********************************************************************
 *	Copyright (C) 2019-2020
 * 	File Name:	SphereRotateDelay.cs
 *	Author:	Luther Shaw
 **********************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using wvr;

public class SphereRotateDelay : MonoBehaviour {
	[Range (10, 100)]
	public int rotateSpeed = 10;
	[Range (1, 5)]
	public int delayTime = 3;
	private float timer = 0f;
	private Vector3 headRotate;
	void Start () {
		headRotate = WaveVR_DevicePoseTracker.HeadRotationValue;
	}
	void Update () {
		SphereRotate ();
	}
	private void SphereRotate () {
		if (WaveVR_DevicePoseTracker.HeadRotationValue == headRotate) {
			timer += Time.deltaTime;
			if (timer >= delayTime) {
				transform.Rotate (Vector3.up * Time.deltaTime * -rotateSpeed, Space.Self);
			}
		} else {
			timer = 0f;
			headRotate = WaveVR_DevicePoseTracker.HeadRotationValue;
		}
	}
}
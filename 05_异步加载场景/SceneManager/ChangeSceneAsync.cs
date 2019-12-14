/**********************************************************************
 *	Copyright (C) 2019-2020
 * 	File Name:	ChangeSceneAsync.cs
 *	Author:	Luther Shaw
 **********************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeSceneAsync : MonoBehaviour {
	private Slider loadSlider;
	private Text loadText;
	private AsyncOperation asyncOperation;
	private float targetValue;
	[Range (0.1f, 1.0f)]
	public float loadingSpeed = 0.5f;
	void Awake () {
		loadSlider = GetComponentInChildren<Slider> ();
		loadText = GetComponentInChildren<Text> ();
	}
	void Start () {
		if (SceneManager.GetActiveScene ().name == "LoadingScene") {
			asyncOperation = SceneManager.LoadSceneAsync ("MainScene");
			asyncOperation.allowSceneActivation = false;
		}
	}

	void Update () {
		ShowLoadSlider ();
	}
	/// <summary>
	/// 设置加载进度条，显示加载百分比。
	/// </summary>
	private void ShowLoadSlider () {
		if (asyncOperation == null) {
			Debug.LogFormat ("不存在{0}场景，请添加该场景。", asyncOperation.GetType ().Name);
			return;
		}
		targetValue = asyncOperation.progress; //asyncOperation.progress达不到终点值，下文必须重定终点值。
		if (asyncOperation.progress >= 0.9f) {
			targetValue = 1.0f;
		}
		loadSlider.value = Mathf.Lerp (loadSlider.value, targetValue, Time.deltaTime * loadingSpeed); //Mathf.Lerp达不到终点值，下文必须重定终点值。
		loadText.text = ((int) (loadSlider.value * 100)).ToString () + "%";
		if (loadSlider.value >= 0.9f) {
			loadSlider.value = 1.0f;
			loadText.text = "100%";
			asyncOperation.allowSceneActivation = true;
		}
	}
}
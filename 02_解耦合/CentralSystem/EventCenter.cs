/**********************************************************************
 *	Copyright (C) 2019-2020
 * 	File Name:	EventCenter.cs
 *	Author:	Luther Shaw
 **********************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventCenter {
	/// <summary>
	/// 实例化字典，关联枚举和回调两个脚本。
	/// </summary>
	/// <typeparam name="EventReg"></typeparam>
	/// <typeparam name="Delegate"></typeparam>
	/// <returns></returns>
	private static Dictionary<EventReg, Delegate> eventCenterDic = new Dictionary<EventReg, Delegate> ();
	/// <summary>
	/// 添加监听事件之无参方法
	/// </summary>
	/// <param name="eventReg"></param>
	/// <param name="eventCallback"></param>
	public static void AddEventListener (EventReg eventReg, EventCallback eventCallback) {
		if (!eventCenterDic.ContainsKey (eventReg)) {
			eventCenterDic.Add (eventReg, null);
		}
		if (eventCenterDic[eventReg] != null) {
			if (eventCenterDic[eventReg].GetType () != eventCallback.GetType ()) {
				throw new Exception (string.Format ("尝试为事件{0}添加不同类型的委托，当前事件所对应的委托是{1}，要添加的委托类型为{2}", eventReg, eventCenterDic[eventReg].GetType (), eventCallback.GetType ()));
			}
		} else {
			throw new Exception (string.Format ("添加监听错误：事件{0}没有对应的委托", eventReg));
		}
		eventCenterDic[eventReg] = (EventCallback) eventCenterDic[eventReg] + eventCallback;
	}
	/// <summary>
	/// 添加监听事件之带一个参数的方法
	/// </summary>
	/// <param name="eventReg"></param>
	/// <param name="eventCallback"></param>
	/// <typeparam name="T"></typeparam>
	public static void AddEventListener<T> (EventReg eventReg, EventCallback<T> eventCallback) {
		if (!eventCenterDic.ContainsKey (eventReg)) {
			eventCenterDic.Add (eventReg, null);
		}
		if (eventCenterDic[eventReg] != null) {
			if (eventCenterDic[eventReg].GetType () != eventCallback.GetType ()) {
				throw new Exception (string.Format ("尝试为事件{0}添加不同类型的委托，当前事件所对应的委托是{1}，要添加的委托类型为{2}", eventReg, eventCenterDic[eventReg].GetType (), eventCallback.GetType ()));
			}
		} else {
			throw new Exception (string.Format ("添加监听错误：事件{0}没有对应的委托", eventReg));
		}
		eventCenterDic[eventReg] = (EventCallback<T>) eventCenterDic[eventReg] + eventCallback;
	}
	/// <summary>
	/// 移除无参监听
	/// </summary>
	/// <param name="eventReg"></param>
	/// <param name="eventCallback"></param>
	public static void RemoveEventListener (EventReg eventReg, EventCallback eventCallback) {
		if (eventCenterDic.ContainsKey (eventReg)) {
			if (eventCenterDic[eventReg] == null) {
				throw new Exception (string.Format ("移除监听错误：事件{0}没有对应的委托", eventReg));
			} else if (eventCenterDic[eventReg].GetType () != eventCallback.GetType ()) {
				throw new Exception (string.Format ("尝试为事件{0}移除不同类型的委托，当前事件所对应的委托是{1}，要移除的委托类型为{2}", eventReg, eventCenterDic[eventReg].GetType (), eventCallback.GetType ()));
			}
		}
		eventCenterDic[eventReg] = (EventCallback) eventCenterDic[eventReg] - eventCallback;
	}
	/// <summary>
	/// 移除带一个参数的监听
	/// </summary>
	/// <param name="eventReg"></param>
	/// <param name="eventCallback"></param>
	/// <typeparam name="T"></typeparam>
	public static void RemoveEventListener<T> (EventReg eventReg, EventCallback<T> eventCallback) {
		if (eventCenterDic.ContainsKey (eventReg)) {
			if (eventCenterDic[eventReg] == null) {
				throw new Exception (string.Format ("移除监听错误：事件{0}没有对应的委托", eventReg));
			} else if (eventCenterDic[eventReg].GetType () != eventCallback.GetType ()) {
				throw new Exception (string.Format ("尝试为事件{0}移除不同类型的委托，当前事件所对应的委托是{1}，要移除的委托类型为{2}", eventReg, eventCenterDic[eventReg].GetType (), eventCallback.GetType ()));
			}
		}
		eventCenterDic[eventReg] = (EventCallback<T>) eventCenterDic[eventReg] - eventCallback;
	}
	/// <summary>
	/// 广播无参监听
	/// </summary>
	/// <param name="eventReg"></param>
	public static void EventBroadcast (EventReg eventReg) {
		Delegate d;
		if (eventCenterDic.TryGetValue (eventReg, out d)) {
			EventCallback eventCallback = d as EventCallback;
			if (eventCallback != null) {
				eventCallback ();
			}
		} else {
			throw new Exception (string.Format ("广播错误：事件{0}没有对应的委托", eventReg));
			}
		}
	/// <summary>
	/// 广播带一个参数的监听
	/// </summary>
	/// <param name="eventReg"></param>
	public static void EventBroadcast<T> (EventReg eventReg, T arg) {
		Delegate d;
		if (eventCenterDic.TryGetValue (eventReg, out d)) {
			EventCallback<T> eventCallback = d as EventCallback<T>;
			if (eventCallback != null) {
				eventCallback (arg);
			}
		} else {
			throw new Exception (string.Format ("广播错误：事件{0}没有对应的委托", eventReg));
			}
		}
	}
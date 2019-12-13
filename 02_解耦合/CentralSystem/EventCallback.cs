/**********************************************************************
 *	Copyright (C) 2019-2020
 * 	File Name:	EventCallback.cs
 *	Author:	Luther Shaw
 **********************************************************************/
/// <summary>
/// 无参委托
/// </summary>
public delegate void EventCallback ();
/// <summary>
/// 带一个参数的委托
/// </summary>
/// <param name="firstParam"></param>
/// <typeparam name="T"></typeparam>
public delegate void EventCallback<T> (T firstParam);
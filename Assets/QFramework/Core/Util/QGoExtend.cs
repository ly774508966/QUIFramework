﻿using UnityEngine;
using System.Collections;

/// <summary>
/// GameObject扩展
/// </summary>
namespace QFramework {
	
	public static class QGoExtend  {


		public static void OnClick(this GameObject go,QVoidDelegate.WithVoid callback)
		{
			QFramework.UI.QUIEventListener.Get (go);

			var listener = QFramework.UI.QUIEventListener.CheckAndAddListener (go);
			listener.onClick += callback;
		}



		public static void Show(Transform trans)
		{
			trans.gameObject.SetActive (true);
		}

		public static void Show(GameObject gameObj)
		{
			gameObj.SetActive (true);
		}

		public static void Hide(Transform trans)
		{
			trans.gameObject.SetActive (false);
		}

		public static void Hide(GameObject gameObj)
		{
			gameObj.SetActive (false);
		}
	}
}

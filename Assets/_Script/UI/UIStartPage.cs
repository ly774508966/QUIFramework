using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QFramework;
using QFramework.UI;
using QFramework.Event;
using QFramework.Extend;

public class UIStartPage : QUIBehaviour
{
	protected override void InitUI(object uiData = null)
	{
		mUIComponents = mIComponents as UIStartPageComponents;
		//please add init code here
	}
	public override void ProcessMsg (QMsg msg)
	{
		throw new System.NotImplementedException ();
	}
	protected override void RegisterUIEvent()
	{
	}
	protected override void OnShow()
	{
		base.OnShow();
	}

	protected override void OnHide()
	{
		base.OnHide();
	}

	void ShowLog(string content)
	{
		Debug.Log("[ UIStartPage:]" + content);
	}

	UIStartPageComponents mUIComponents = null;
}
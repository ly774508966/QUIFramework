using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QFramework;
using QFramework.UI;
public class UIStartPageComponents : IUIComponents
{
	public void InitUIComponents()
	{
		Image_Image = QUGUIMgr.Instance.Get<UIStartPage>("Image").GetComponent<Image>();
	}

	public void Clear()
	{
		Image_Image = null;
	}

	public Image Image_Image;
}

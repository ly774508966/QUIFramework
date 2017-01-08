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
		Image_Image = QUIManager.Instance.Get<UIStartPage>("Image").GetComponent<Image>();
		Button_Button = QUIManager.Instance.Get<UIStartPage>("Button").GetComponent<Button>();
	}

	public void Clear()
	{
		Image_Image = null;
		Button_Button = null;
	}

	public Image Image_Image;
	public Button Button_Button;
}

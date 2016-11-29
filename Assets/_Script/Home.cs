using UnityEngine;
using System.Collections;
using QFramework;
using QFramework.UI;

public class Home : MonoBehaviour {

	void Start () {
		QUIManager.Instance.OpenUI<UIStartPage>(CanvasLevel.Bottom,null,null);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

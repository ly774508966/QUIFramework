using UnityEngine;
using System.Collections;
using QFramework;
using QFramework.UI;

public class Home : MonoBehaviour {

	void Start () {
		QUIManager.Instance.OpenUI<UIStartPage>(QUILevel.Common,null,null);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

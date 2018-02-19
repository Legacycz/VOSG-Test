using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformText : MonoBehaviour {
    [SerializeField]
    private Text buttonText;

	// Use this for initialization
	void Start ()
    {
#if UNITY_STANDALONE
        buttonText.text = "Standalone";
#elif UNITY_WEBGL
        buttonText.text = "WebGL";
#elif UNITY_ANDROID
        buttonText.text = "Android";
#endif
    }

    // Update is called once per frame
    void Update () {
		
	}
}

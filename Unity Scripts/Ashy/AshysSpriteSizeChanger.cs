using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AshysSpriteSizeChanger : MonoBehaviour {

    RectTransform _t;
    Image _i;

	void Start ()
    {
        _t = GetComponent<RectTransform>();
        _i = GetComponent<Image>();
	}
	
	void Update ()
    {
        Texture2D _tex = _i.sprite.texture;
        //_t.localPosition = new Vector2(0,11);
        _t.sizeDelta = new Vector2(_tex.width, _tex.height);
	}
}

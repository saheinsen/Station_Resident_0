using UnityEngine;
using System.Collections;

public class LoreGUI : MonoBehaviour {


    public LoreMngmt loremngmt;

    public void OnGUI()
    {
        loremngmt = gameObject.GetComponent<LoreMngmt>();
        GUI.backgroundColor = Color.black;
        GUI.contentColor = Color.white;
        GUI.Button(new Rect(50, 50, 500, 200), loremngmt.Loretext);
    }
}

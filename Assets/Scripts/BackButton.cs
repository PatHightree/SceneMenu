using UnityEngine;

public class BackButton : MonoBehaviour {

	public void OnGUI () {
		GUI.BeginGroup(new Rect(Screen.width / 2.0f - 150, Screen.height / 2.0f, 300, 400));
		GUILayout.BeginVertical("box", GUILayout.Width(300));

		if (GUILayout.Button("Back"))
			Application.LoadLevel(0);

		GUILayout.EndVertical();
		GUI.EndGroup();
	}
}

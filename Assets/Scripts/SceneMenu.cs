using UnityEngine;

public class SceneMenu : MonoBehaviour {

	public void OnGUI () {
		ScenesList scenes = (ScenesList) Resources.Load("Scenes list");

		// Create a button for each scene.
		GUI.BeginGroup(new Rect(Screen.width/2 - 150, Screen.height/2, 300, 400));
		GUILayout.BeginVertical("box", GUILayout.Width(300));
		for (int i = 1; i < scenes.Scenes.Count; i++) {
			if (GUILayout.Button(scenes.Scenes[i].Name))
				Application.LoadLevel(scenes.Scenes[i].Index);
		}
		GUILayout.EndVertical();
		GUI.EndGroup();
	}
}

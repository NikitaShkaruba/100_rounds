using System.Collections;
using UnityEngine;

public class LogShower : MonoBehaviour {
    private readonly Queue queue = new();

    public void Start() {
        Debug.Log("Started up logging");
    }

    public void OnEnable() {
        Application.logMessageReceived += HandleLog;
    }

    public void OnDisable() {
        Application.logMessageReceived -= HandleLog;
    }

    public void OnGUI() {
        GUILayout.BeginArea(new Rect(Screen.width - 1070, 0, 400, Screen.height));
        GUILayout.Label("\n" + string.Join("\n", queue.ToArray()));
        GUILayout.EndArea();
    }

    private void HandleLog(string logString, string stackTrace, LogType type) {
        queue.Enqueue(logString);

        if (type == LogType.Exception) {
            queue.Enqueue(stackTrace);
        }

        // Cut down the log
        while (queue.Count > 10) {
            queue.Dequeue();
        }
    }
}
using UnityEngine;
using System.Collections;

public class LogShower : MonoBehaviour
{
    Queue queue = new Queue();

    void Start() {
        Debug.Log("Started up logging.");
    }

    void OnEnable() {
        Application.logMessageReceived += HandleLog;
    }

    void OnDisable() {
        Application.logMessageReceived -= HandleLog;
    }

    void HandleLog(string logString, string stackTrace, LogType type) {
        queue.Enqueue(logString);
        
        if (type == LogType.Exception) {
            queue.Enqueue(stackTrace);
        }

        // Cut down the log
        while (queue.Count > 10) {
            queue.Dequeue();
        }
    }

    void OnGUI() {
        GUILayout.BeginArea(new Rect(Screen.width - 1070, 0, 400, Screen.height));
        GUILayout.Label("\n" + string.Join("\n", queue.ToArray()));
        GUILayout.EndArea();
    }
}
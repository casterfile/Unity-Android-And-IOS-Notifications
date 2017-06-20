using UnityEngine;
using System.Collections;

public class TestGUI : MonoBehaviour {

    void OnGUI()
    {   
        if (GUI.Button(new Rect(5, 5, 300, 100), "Send Notification in 5 seconds"))
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            //send notification here
            AndroidJavaObject ajc = new AndroidJavaObject("com.zeljkosassets.notifications.Notifier");
            ajc.CallStatic("sendNotification", "Test Name", "Test Title", "Test Label", 5);
#else
            Debug.LogWarning("This asset is for Android only. It will not work inside the Unity editor!");
#endif

        }
    }
}

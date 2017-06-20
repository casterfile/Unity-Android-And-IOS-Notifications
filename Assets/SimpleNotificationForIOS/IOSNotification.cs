using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IOSNotification : MonoBehaviour {
	void Start()
    {
        // schedule notification to be delivered in 10 seconds
        UnityEngine.iOS.LocalNotification notif = new UnityEngine.iOS.LocalNotification();
        notif.fireDate = DateTime.Now.AddSeconds(10);
        notif.alertBody = "Hello!";
        UnityEngine.iOS.NotificationServices.ScheduleLocalNotification(notif);
    }

    void Update()
    {
        if (UnityEngine.iOS.NotificationServices.localNotificationCount > 0) {
            Debug.Log(UnityEngine.iOS.NotificationServices.localNotifications[0].alertBody);
            UnityEngine.iOS.NotificationServices.ClearLocalNotifications();
        }
    }
}

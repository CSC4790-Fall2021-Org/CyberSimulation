using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Notifications dialogue;
    public void TriggerNotifications()
    {
        FindObjectOfType<NotificationsManager>().StartNotifications(dialogue);
    }
}

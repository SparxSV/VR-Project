using System;
using UnityEngine;

enum AnalogValue
{
    SECOND = 0,
    MINUTE,
    HOUR
}

public class AnalogClock : MonoBehaviour
{
    [SerializeField] private Transform hand;
    [SerializeField] private AnalogValue analogValue;

    private DateTime time;

    private void Update()
    {
        time = DateTime.Now;

        switch(analogValue)
        {
            case AnalogValue.SECOND:
                RotateSecondsHand(time.Second);
                break;

            case AnalogValue.MINUTE:
                RotateMinutesHand(time.Minute);
                break;

            case AnalogValue.HOUR:
                RotateHourHand(time.Hour);
                break;
        }
    }

    private void RotateSecondsHand(float _seconds)
    {
        hand.eulerAngles = new Vector3(_seconds * 6 * 1.0f, 0, 90);
    }

    private void RotateMinutesHand(float _minutes)
    {
        hand.eulerAngles = new Vector3(_minutes * 6 * 1.0f, 0, 90);
    }

    private void RotateHourHand(float _hour)
    {
        hand.eulerAngles = new Vector3(_hour * 6 * 1.0f, 0, 90);
    }
}

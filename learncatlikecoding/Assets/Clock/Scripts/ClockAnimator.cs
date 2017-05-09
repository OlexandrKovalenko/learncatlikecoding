using UnityEngine;
using System;

public class ClockAnimator : MonoBehaviour
{
  public Transform Hours;
  public Transform Minuutes;
  public Transform Seconds;

  private const float _hoursToDegrees = 360f / 12f;
  private const float _minuntesToDegrees =  360f / 60f;
  private const float _secondsToDegrees =  360f / 60f;

  public bool AnalogClock;

  private void Update()
  {
    if (AnalogClock)
    {
      TimeSpan timespan = DateTime.Now.TimeOfDay;
      Hours.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.TotalHours * -_hoursToDegrees);
      Minuutes.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.TotalMinutes * -_minuntesToDegrees);
      Seconds.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.Seconds * -_secondsToDegrees);
    }
    else
    {
      DateTime time = DateTime.Now;
      Hours.localRotation = Quaternion.Euler(0f, 0f, time.Hour * -_hoursToDegrees);
      Minuutes.localRotation = Quaternion.Euler(0f, 0f, time.Minute * -_minuntesToDegrees);
      Seconds.localRotation = Quaternion.Euler(0f, 0f, time.Second * -_secondsToDegrees);
    }
  }
}
using System; using System.Collections; using System.Collections.Generic; using UnityEngine;

public class Clock : MonoBehaviour 
{ 
	public Transform hourHandTransform; 
	public Transform minuteHandTransform; 
	public Transform secondHandTransform; 


// Update is called once per frame
void Update()
{
    DateTime currentTime = DateTime.Now;
    float hours   = currentTime.Hour % 12 + currentTime.Minute / 60f;
    float minutes = currentTime.Minute + currentTime.Second / 60f;
    float seconds = currentTime.Second;

    // Adjust the rotation of the clock hands
    hourHandTransform.localRotation = Quaternion.Euler(hours * 30f, 0, 0);
    minuteHandTransform.localRotation = Quaternion.Euler(minutes * 6f, 0, 0);
    secondHandTransform.localRotation = Quaternion.Euler(seconds * 6f, 0, 0);
	Debug.Log("Current Time: " + currentTime.ToString("HH:mm:ss"));
	Debug.Log("Hours: " + hours);
	Debug.Log("Minutes: " + minutes);
	Debug.Log("Seconds: " + seconds);
	Debug.Log("Hour Hand Rotation: " + hourHandTransform.localRotation.eulerAngles);
	Debug.Log("Minute Hand Rotation: " + minuteHandTransform.localRotation.eulerAngles);
	Debug.Log("Second Hand Rotation: " + secondHandTransform.localRotation.eulerAngles);	
}
}

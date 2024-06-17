using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBook : MonoBehaviour
{

	public GameObject cover;
	public HingeJoint myHinge;
	
	void Start()
	{
		Debug.Log("OpenBook started");
		myHinge = cover.GetComponent<HingeJoint>();
		
		myHinge.useMotor = false;
	}
	
	public void OpenCover()
	{
		myHinge.useMotor = true;
		Debug.Log("OpenCover");
	}
	
	public void CloseCover()
	{
		myHinge.useMotor = false;
		Debug.Log("CloseCover");
	}
}
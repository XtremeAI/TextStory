using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour {

	[SerializeField] Text _storyText;
	[SerializeField] State _startingState;

	State _storyState;
	// Use this for initialization
	void Start () {
		_storyState = _startingState;
		_storyText.text = _storyState.GetStoryState();
	}
	
	// Update is called once per frame
	void Update () {
		ManageState();
	}

  private void ManageState()
  {
    var nextStates = _storyState.GetNextStates();
		if (Input.GetKeyDown(KeyCode.Alpha1)){
			_storyState = nextStates[0];
			_storyText.text = _storyState.GetStoryState();
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2)){
			_storyState = nextStates[1];
			_storyText.text = _storyState.GetStoryState();
		}
  }
}

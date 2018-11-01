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
		bool isStateChanged = false;
    var nextStates = _storyState.GetNextStates();

    if (Input.GetKeyDown(KeyCode.Space))
    {
      _storyState = nextStates[0];
			isStateChanged = true;
    }

    for (int i = 0; i < nextStates.Count; i++) {
			if (Input.GetKeyDown(KeyCode.Alpha1 + i)){
				_storyState = nextStates[i];
        isStateChanged = true;
      }
		}

		if (isStateChanged) {
	    _storyText.text = _storyState.GetStoryState();
		}
  }
}

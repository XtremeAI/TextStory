using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {

	[SerializeField, TextArea(10,14)] string _storyText;
	[SerializeField] State[] _nextStates;

	public string GetStoryState(){
		return _storyText;
	}

	public State[] GetNextStates(){
		return _nextStates;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {

	[SerializeField, TextArea(10,14)] string _storyText;
	[SerializeField] List<State> _nextStates;

	public string GetStoryState(){
		return _storyText;
	}

	public List<State> GetNextStates(){
		return _nextStates;
	}
}

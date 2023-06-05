using UnityEngine;
using Arbor;

[AddComponentMenu("")]
public class LoadingState : StateBehaviour {

	public StateLink _nextState;

	// Use this for initialization
	void Start () {
	
	}

	// Use this for awake state
	public override void OnStateAwake() {
	}

	// Use this for enter state
	public override void OnStateBegin() {
	}

	// Use this for exit state
	public override void OnStateEnd() {
	}
	
	// OnStateUpdate is called once per frame
	public override void OnStateUpdate() {
		if (Input.GetKeyDown(KeyCode.Space)) 
		{
        	Transition(_nextState);
    	}
	}

	// OnStateLateUpdate is called once per frame, after Update has finished.
	public override void OnStateLateUpdate() {
	}
}

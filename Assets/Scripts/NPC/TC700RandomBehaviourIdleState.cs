﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TC700RandomBehaviourIdleState : StateMachineBehaviour {

	public string m_parameterName = "idleIndex";
	public int[] m_stateIndexArray = {0,1,2,3};

    // OnStateEnter is called before OnStateEnter is called on any state inside this state machine
	//override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateUpdate is called before OnStateUpdate is called on any state inside this state machine
	//override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateExit is called before OnStateExit is called on any state inside this state machine
	//override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateMove is called before OnStateMove is called on any state inside this state machine
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called before OnStateIK is called on any state inside this state machine
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateMachineEnter is called when entering a statemachine via its Entry Node
	override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
	{

		if (m_stateIndexArray.Length <= 0)
		{
			animator.SetInteger(m_parameterName, 0);
		} else {
			
			int index = Random.Range(0, m_stateIndexArray.Length);

			animator.SetInteger(m_parameterName, m_stateIndexArray[index]);
		}
	}

	// OnStateMachineExit is called when exiting a statemachine via its Exit Node
	// override public void OnStateMachineExit(Animator animator, int stateMachinePathHash) {
	// }
}

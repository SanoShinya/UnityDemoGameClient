﻿//-----------------------------------------------------
//            Arbor 3: FSM & BT Graph Editor
//		  Copyright(c) 2014-2021 caitsithware
//-----------------------------------------------------
using UnityEditor;

using Arbor.StateMachine.StateBehaviours;

namespace ArborEditor.StateMachine.StateBehaviours
{
	[CustomEditor(typeof(AgentHideFromPosition))]
	internal sealed class AgentHideFromPositionInspector : AgentMoveBaseInspector
	{
		protected override void OnRegisterElements()
		{
			base.OnRegisterElements();

			RegisterProperty("_ObstacleTargetFlags");
			RegisterProperty("_ObstacleSearchFlags");
			RegisterProperty("_ObstacleLayer");
			RegisterProperty("_MinDistanceToTarget");
			RegisterProperty("_TargetPosition");
		}
	}
}
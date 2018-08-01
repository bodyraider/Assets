using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit2D
{
    public class ChomperFlySMB : SceneLinkedSMB<EnemyBehaviour>
    {
        public override void OnSLStateNoTransitionUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            base.OnSLStateNoTransitionUpdate(animator, stateInfo, layerIndex);
            m_MonoBehaviour.SetVerticalSpeed(5);

        }
        public override void OnSLStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            base.OnSLStateExit(animator, stateInfo, layerIndex);

            m_MonoBehaviour.SetVerticalSpeed(-5);
        }
    }
}
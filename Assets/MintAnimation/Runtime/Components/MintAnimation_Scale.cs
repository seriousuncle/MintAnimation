﻿using MintAnimation.Core;
using UnityEngine;

namespace MintAnimation
{
    [AddComponentMenu("MintAnimation/ScaleAnimation", 1)]
    public class MintAnimation_Scale : MintAnimation_Base<Vector3>
    {
        [SerializeField]
        private MintAnimationDataVector MintAnimationData = new MintAnimationDataVector();
        
        protected override void setter(Vector3 value)
        {
                transform.localScale = value;
        }

        protected override MintAnimationData<Vector3> getAnimationData()
        {
            return MintAnimationData;
        }

        protected override Vector3 getter()
        {
                return transform.localScale;
        }
        
    }
}

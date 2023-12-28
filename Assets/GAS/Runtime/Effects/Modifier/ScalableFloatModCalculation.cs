﻿using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace GAS.Runtime.Effects.Modifier
{
    [CreateAssetMenu(fileName = "ScalableFloatModCalculation", menuName = "GAS/MMC/ScalableFloatModCalculation")]
    public class ScalableFloatModCalculation:ModifierMagnitudeCalculation
    {
        [SerializeField] private float k;
        [SerializeField] private float b;
        
        public override float CalculateMagnitude(params float[] input)
        {
            return input[0] * k + b;
        }
    }
}
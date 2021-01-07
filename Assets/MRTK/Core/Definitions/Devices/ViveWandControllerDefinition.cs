﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.MixedReality.Toolkit.Utilities;
using System;

namespace Microsoft.MixedReality.Toolkit.Input
{
    /// <summary>
    /// 
    /// </summary>
    public class ViveWandControllerDefinition : BaseInputSourceDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handedness"></param>
        public ViveWandControllerDefinition(Handedness handedness) : base(handedness)
        {
            if ((handedness != Handedness.Left) &&
                (handedness != Handedness.Right))
            {
                throw new ArgumentException($"Unsupported Handedness ({handedness}). The ViveWandControllerDefinition supports Left and Right.");
            }
        }

        /// <inheritdoc />
        protected override MixedRealityInputActionMapping[] DefaultMappings => new[]
        {
            new MixedRealityInputActionMapping("Spatial Pointer", AxisType.SixDof, DeviceInputType.SpatialPointer),
            new MixedRealityInputActionMapping("Trigger Position", AxisType.SingleAxis, DeviceInputType.Trigger),
            new MixedRealityInputActionMapping("Trigger Press (Select)", AxisType.Digital, DeviceInputType.Select),
            new MixedRealityInputActionMapping("Trigger Touch", AxisType.Digital, DeviceInputType.TriggerTouch),
            new MixedRealityInputActionMapping("Grip Press", AxisType.SingleAxis, DeviceInputType.Trigger),
            new MixedRealityInputActionMapping("Trackpad Position", AxisType.DualAxis, DeviceInputType.Touchpad),
            new MixedRealityInputActionMapping("Trackpad Touch", AxisType.Digital, DeviceInputType.TouchpadTouch),
            new MixedRealityInputActionMapping("Trackpad Press", AxisType.Digital, DeviceInputType.TouchpadPress),
            new MixedRealityInputActionMapping("Menu Button", AxisType.Digital, DeviceInputType.ButtonPress),
        };
    }
}
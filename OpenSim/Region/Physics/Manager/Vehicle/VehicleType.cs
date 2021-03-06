/*
 * Copyright (c) 2015, InWorldz Halcyon Developers
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 * 
 *   * Redistributions of source code must retain the above copyright notice, this
 *     list of conditions and the following disclaimer.
 * 
 *   * Redistributions in binary form must reproduce the above copyright notice,
 *     this list of conditions and the following disclaimer in the documentation
 *     and/or other materials provided with the distribution.
 * 
 *   * Neither the name of halcyon nor the names of its
 *     contributors may be used to endorse or promote products derived from
 *     this software without specific prior written permission.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
 * FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
 * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
 * CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
 * OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
 * OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenSim.Region.Physics.Manager.Vehicle
{
    /// <summary>
    /// Enum containing all the LSL vehicle types ( http://wiki.secondlife.com/wiki/LlSetVehicleType )
    /// 
    /// Please note if you update this enum you should also update the validator below to include the new range(s)
    /// </summary>
    public enum VehicleType
    {
        None        = 0,
        Sled        = 1,
        Car         = 2,
        Boat        = 3,
        Airplane    = 4,
        Balloon     = 5,

        Initialize  = 10000,    // internal use only
        Sailboat    = 10001,
        Motorcycle  = 10002,
    }

    /// <summary>
    /// This is kind of verbose for checking the validity of the enum, but it will be fast at runtime
    /// unlike Enum.IsDefined() ( see: http://stackoverflow.com/questions/13615/validate-enum-values )
    /// </summary>
    public class VehicleTypeValidator
    {
        public const int VEHICLE_TYPE_MIN = (int)VehicleType.None;
        public const int VEHICLE_TYPE_MAX = (int)VehicleType.Balloon;
        public const int VEHICLE_TYPE_MIN2 = (int)VehicleType.Sailboat;
        public const int VEHICLE_TYPE_MAX2 = (int)VehicleType.Motorcycle;

        public static bool IsValid(int value)
        {
            if (value >= VEHICLE_TYPE_MIN && value <= VEHICLE_TYPE_MAX) return true;
            if (value >= VEHICLE_TYPE_MIN2 && value <= VEHICLE_TYPE_MAX2) return true;
            return false;
        }
    }
}

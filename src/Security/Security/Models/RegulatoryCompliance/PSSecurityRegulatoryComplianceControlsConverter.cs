﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Management.Security.Models;
namespace Microsoft.Azure.Commands.SecurityCenter.Models.RegulatoryCompliance
{
    public static class PSSecurityRegulatoryComplianceControlsConverter
    {
        public static PSSecurityRegulatoryComplianceControls ConvertToPSType(this RegulatoryComplianceControl value)
        {
            return new PSSecurityRegulatoryComplianceControls()
            {
                Id = value.Id,
                Name = value.Name,
            };
        }

        public static List<PSSecurityRegulatoryComplianceControls> ConvertToPSType(this IEnumerable<RegulatoryComplianceControl> value)
        {
            return value.Select(control => control.ConvertToPSType()).ToList();
        }
    }
}

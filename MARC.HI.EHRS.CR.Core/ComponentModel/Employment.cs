﻿/**
 * Copyright 2013-2013 Mohawk College of Applied Arts and Technology
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); you 
 * may not use this file except in compliance with the License. You may 
 * obtain a copy of the License at 
 * 
 * http://www.apache.org/licenses/LICENSE-2.0 
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the 
 * License for the specific language governing permissions and limitations under 
 * the License.
 * 
 * User: fyfej
 * Date: 6-2-2013
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using MARC.HI.EHRS.SVC.Core.ComponentModel.Components;
using MARC.HI.EHRS.SVC.Core.DataTypes;

namespace MARC.HI.EHRS.CR.Core.ComponentModel
{
    /// <summary>
    /// Employment
    /// </summary>
    [XmlType("Employment", Namespace = "urn:marc-hi:svc:componentModel")]
    [Serializable]
    public class Employment
    {

        /// <summary>
        /// Gets ors ets the id
        /// </summary>
        [XmlAttribute("id")]
        public decimal Id { get; set; }

        /// <summary>
        /// Gets or sets the update mode
        /// </summary>
        [XmlAttribute("updateMode")]
        public UpdateModeType UpdateMode { get; set; }

        /// <summary>
        /// Gets or sets the effective time
        /// </summary>
        [XmlElement("efft")]
        public TimestampSet EffectiveTime { get; set; }

        /// <summary>
        /// Gets or sets the occupation 
        /// </summary>
        [XmlElement("occupation")]
        public CodeValue Occupation { get; set; }

        /// <summary>
        /// Gets or sets the status
        /// </summary>
        [XmlAttribute("status")]
        public StatusType Status { get; set; }

    }
}

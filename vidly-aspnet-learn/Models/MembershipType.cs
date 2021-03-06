﻿#region Copyright

// Maxotek CONFIDENTIAL INFORMATION
// © 2007-2016 Maxotek Inc.
// All Rights Reserved
//                                                                   
// This program contains confidential and proprietary information   
// of the Maxotek, Inc.  Any reproduction, disclosure, or use       
// in whole or in part is expressly prohibited, except as may be    
// specifically authorized by prior written agreement.

#endregion

#region Imports

using System.ComponentModel.DataAnnotations;

#endregion

namespace vidly_aspnet_learn.Models
{
    public class MembershipType
    {
        public const byte Unknown = 0;
        public const byte PayAsYouGo = 1;
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public short SignupFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}
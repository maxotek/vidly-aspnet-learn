#region Copyright

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

using System;

#endregion

namespace vidly_aspnet_learn.Models
{
    public interface ICustomer
    {
        byte MembershipTypeId { get; set; }
        DateTime? BirthDate { get; set; }
    }
}
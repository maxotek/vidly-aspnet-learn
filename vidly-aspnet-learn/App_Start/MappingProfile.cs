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

using AutoMapper;
using vidly_aspnet_learn.Dtos;
using vidly_aspnet_learn.Models;

#endregion

namespace vidly_aspnet_learn.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ;
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}
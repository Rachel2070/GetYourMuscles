using AutoMapper;
using Gym_Management.Core.DTOs;
using Gym_Management.Core.TDOs;
using GYM_Managing.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Core
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Staff, StaffDto>().ReverseMap();
            CreateMap<Subscriber, SubscriberDto>().ReverseMap();
            CreateMap<Equipment, EquipmentDto>().ReverseMap();
        }
    }
}

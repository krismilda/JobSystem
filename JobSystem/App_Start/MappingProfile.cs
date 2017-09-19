using AutoMapper;
using JobSystem.Dtos;
using JobSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobSystem.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Job, JobDTO>();
            Mapper.CreateMap<JobDTO, Job>();
        }
    }
}
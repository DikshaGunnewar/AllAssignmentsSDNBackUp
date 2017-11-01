using _09Aug2017AssigmnetToBeCompleted.Dto;
using _09Aug2017AssigmnetToBeCompleted.Models;
using AutoMapper;

namespace _09Aug2017AssigmnetToBeCompleted.App_Start
{
    public class MappingProfile:Profile
    {

        public MappingProfile()
        {
            CreateMap<StudentViewModel, StudentDto>();
            CreateMap<StudentDto, StudentViewModel>();
        }
        /* public MappingProfile()
         {
             CreateMap<StudentViewModel, StudentDto>();
             CreateMap<StudentDto, StudentViewModel>();
         }*/
    }
}
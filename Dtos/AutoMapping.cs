using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class AutoMapping : Profile
    {
        Object config = new MapperConfiguration(cfg => {
            cfg.CreateMap<Customer, CustomerDto>();
            cfg.CreateMap<CustomerDto, Customer>();
        });
    }
}

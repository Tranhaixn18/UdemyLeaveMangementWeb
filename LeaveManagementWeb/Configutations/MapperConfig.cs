using AutoMapper;
using LeaveManagementWeb.Data;
using LeaveManagementWeb.Models;

namespace LeaveManagementWeb.Configutations
{
    public class MapperConfig:Profile
    {
        public MapperConfig() {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}

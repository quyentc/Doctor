﻿using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Bases;
using Api.Doctor.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;



namespace Api.Doctor.Repositories.Implementations
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(DoctorCareDbContext context) : base(context)
        {
        }
    }
}
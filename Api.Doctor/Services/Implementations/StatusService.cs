﻿using Api.Doctor.EFCoreContext;
using Api.Doctor.Models;
using Api.Doctor.Repositories.Interfaces;
using Api.Doctor.Services.Bases;
using Api.Doctor.Services.Interfaces;


namespace Api.Doctor.Services.Implementations
{
    public class StatusService : BaseService<Status>, IStatusService
    {
        public StatusService(IStatusRepository repository)
            : base(repository)
        {
        }
    }
}
﻿using IOTManagementGroup7.DataAccess.Data;
using IOTManagementGroup7.DataAccess.Repository.IRepository;
using IOTManagementGroup7.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOTManagementGroup7.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Camera = new CameraRepository(_db);
            Light = new LightRepository(_db);
            TV = new TVRepository(_db);
            Fridge = new FridgeRepository(_db);
            SP_Call = new SP_Call(_db);
        }


        public ICameraRepository Camera { get; private set; }
        public ILightRepository Light { get; private set; }
        public ITVRepository TV { get; private set; }
        public IFridgeRepository Fridge { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}

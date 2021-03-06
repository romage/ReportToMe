﻿using ReportToMe.Web.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportToMe.Models;
using ReportToMe.Services.Interfaces;

namespace ReportToMe.Services
{
    public class MeetingService: IMeetingService
    {
        IMeetingRepository _repo;
        IUnitOfWork  _uow;

        public MeetingService(IMeetingRepository repository, IUnitOfWork unitOfWork)
        {
            this._repo = repository;
            this._uow = unitOfWork;
        }

        public async Task<IEnumerable<Meeting>> ListMeetingsAsync()
        {
            return await _repo.ListAllAsync();
        }

        public Task<IEnumerable<Meeting>> ListMeetingsAsync(Func<Meeting, bool> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Meeting> List()
        {
            return _repo.ListAll();
        }

        public IEnumerable<Meeting> List(Func<Meeting, bool> where)
        {
            throw new NotImplementedException();
        }

        public Meeting Find(Func<Meeting, bool> where)
        {
            return _repo.ListAll().Where(where).FirstOrDefault();
        }

        public Meeting Add(Meeting entity)
        {
            _repo.Add(entity);
            _uow.SaveChanges();
            return entity;
        }

        public async Task<Meeting> AddAsync(Meeting entity)
        {
            _repo.Add(entity);
            Task t = _uow.SaveChangesAsync();
            await t;
            return entity;
        }

        

        public bool Delete(int Id)
        {
            var entity = _repo.Find(Id);
            return Delete(entity);
        }

        public bool Delete(Meeting entity)
        {
            _repo.Delete(entity);
            _uow.SaveChanges();
            return true;
        }

        public void Dispose()
        {
            _repo.Dispose();
            _uow.Dispose();
        }

        public Meeting MeetingsWithAllDepartments(int meetingId)
        {
            return _repo.MeetingsWithAllDepartments(meetingId);
        }


        public bool UpdateContent(int meetingProjectId, int departmentId, int departmentUpdateId, string newContent)
        {
            return _repo.UpdateContent(meetingProjectId, departmentId, departmentUpdateId, newContent);
        }
    }
}

﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProjectManager : IProjectService
    {
        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)//constructor
        {
            _projectDal = projectDal;
        }

        public void TAdd(Project t)
        {
            _projectDal.Insert(t);
        }

        public void TDelete(Project t)
        {
            _projectDal.Delete(t);
        }

        public Project TGetByID(int id)
        {
            return _projectDal.GetByID(id);
        }

        public List<Project> TGetList()
        {
            return _projectDal.GetList();
        }

        public void TUpdate(Project t)
        {
            _projectDal.Update(t);
        }
    }
}

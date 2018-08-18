﻿namespace TextbookSubscription.Repository
{
    using System.Collections.Generic;
    using TextbookSubscription.Domain;
    using TextbookSubscription.Domain.Entity;
    using TextbookSubscription.Domain.IRepositories;

    public class DepartmentRepository : EFRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(IRepositoryDbContext context)
            : base(context)
        {

        }

        public IEnumerable<Department> GetDepartmentBySchoolID(string schoolID)
        {
            var departmentList = Find(d => d.SchoolID == schoolID);
            return departmentList;
        }
    }
}

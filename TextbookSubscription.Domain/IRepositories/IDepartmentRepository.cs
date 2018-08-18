namespace TextbookSubscription.Domain.IRepositories
{
    using TextbookSubscription.Domain.Entity;
    using System.Collections.Generic;

    public interface IDepartmentRepository : IRepository<Department>
    {
        /// <summary>
        /// 根据学院ID获得教研室集合
        /// </summary>
        /// <param name="schoolID">学院ID</param>
        /// <returns>教研室集合</returns>
        IEnumerable<Department> GetDepartmentBySchoolID(string schoolID);
    }
}

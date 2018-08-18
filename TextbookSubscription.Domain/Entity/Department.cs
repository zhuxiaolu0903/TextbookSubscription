namespace TextbookSubscription.Domain.Entity
{
    public class Department: AggregateRoot
    {
        /// <summary>
        /// 教研室ID
        /// </summary>
        public string DepartmentID { get; set; }

        /// <summary>
        /// 学院ID
        /// </summary>
        public string SchoolID { get; set; }

        /// <summary>
        /// 教研室名称
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Telephone { get; set; }
    }
}

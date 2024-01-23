﻿namespace Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        public string Title { get; set; }

        /// <summary>
        /// توضیحات متنی تیکت یا درخواست
        /// </summary>
        public string Description { get; set; }

        public PriorityEnum Priority { get; set; }

        //public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        /// <summary>
        /// زمان ثبت تیکت
        /// </summary>
        public DateTime SubmittedAt { get; set; }
        
        /// <summary>
        /// آی دی شخصی که تیکت را ثبت کرده است
        /// </summary>
        public int SubmittedBy { get; set; }
    }

    //public class Department
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
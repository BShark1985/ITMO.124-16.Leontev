//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TASK_09_CourseManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class OnlineCourse
    {
        public int CourseID { get; set; }
        public string URL { get; set; }
    
        public virtual Course Course { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hardware_Store_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Staff_of_employees
    {
        public Staff_of_employees()
        {
            this.Closing_application = new HashSet<Closing_application>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> Salary { get; set; }
        public Nullable<int> Phone { get; set; }
    
        public virtual ICollection<Closing_application> Closing_application { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Api_Nikita.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrainingParts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrainingParts()
        {
            this.InfoTech = new HashSet<InfoTech>();
        }
    
        public int id_trainigpart { get; set; }
        public string auditorium { get; set; }
        public string academic_subject { get; set; }
        public Nullable<int> acc_FK { get; set; }
    
        public virtual Accs Accs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoTech> InfoTech { get; set; }
    }
}

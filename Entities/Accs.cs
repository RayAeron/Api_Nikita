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
    
    public partial class Accs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accs()
        {
            this.TrainingParts = new HashSet<TrainingParts>();
        }
    
        public int id_acc { get; set; }
        public string mylastname { get; set; }
        public string myname { get; set; }
        public string mypatronymic { get; set; }
        public string mylog { get; set; }
        public string mypass { get; set; }
        public string myuniquecode { get; set; }
        public string mycodeusage { get; set; }
        public string rights { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrainingParts> TrainingParts { get; set; }
    }
}

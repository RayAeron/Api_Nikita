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
    
    public partial class InfoTech
    {
        public int id_InfoTech { get; set; }
        public Nullable<int> trainigpart_FK { get; set; }
        public Nullable<int> note_FK { get; set; }
    
        public virtual Notes Notes { get; set; }
        public virtual TrainingParts TrainingParts { get; set; }
    }
}

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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OwndbEntities : DbContext
    {
        public OwndbEntities()
            : base("name=OwndbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accs> Accs { get; set; }
        public virtual DbSet<InfoTech> InfoTech { get; set; }
        public virtual DbSet<Notes> Notes { get; set; }
        public virtual DbSet<Timetables> Timetables { get; set; }
        public virtual DbSet<TrainingParts> TrainingParts { get; set; }
    }
}

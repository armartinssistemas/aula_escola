//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projeto_escola
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class escolaEntities1 : DbContext
    {
        public escolaEntities1()
            : base("name=escolaEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<alunos> alunos { get; set; }
        public virtual DbSet<cursoextra> cursoextra { get; set; }
        public virtual DbSet<cursos> cursos { get; set; }
        public virtual DbSet<disciplina> disciplina { get; set; }
        public virtual DbSet<professores> professores { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
    }
}

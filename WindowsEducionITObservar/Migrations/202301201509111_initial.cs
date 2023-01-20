namespace WindowsEducionITObservar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carreras",
                c => new
                    {
                        CarreraId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.CarreraId);
            
            CreateTable(
                "dbo.Cursoes",
                c => new
                    {
                        CursoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.CursoId);
            
            CreateTable(
                "dbo.Detalles",
                c => new
                    {
                        DetalleId = c.Int(nullable: false, identity: true),
                        PlanillaId = c.Int(nullable: false),
                        EstadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DetalleId)
                .ForeignKey("dbo.Estadoes", t => t.EstadoId, cascadeDelete: true)
                .ForeignKey("dbo.Planillas", t => t.PlanillaId, cascadeDelete: true)
                .Index(t => t.PlanillaId)
                .Index(t => t.EstadoId);
            
            CreateTable(
                "dbo.Estadoes",
                c => new
                    {
                        EstadoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.EstadoId);
            
            CreateTable(
                "dbo.Planillas",
                c => new
                    {
                        PlanillaId = c.Int(nullable: false, identity: true),
                        CarreraId = c.Int(nullable: false),
                        MateriaId = c.Int(nullable: false),
                        ProfesorId = c.Int(nullable: false),
                        CursoId = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PlanillaId)
                .ForeignKey("dbo.Carreras", t => t.CarreraId, cascadeDelete: true)
                .ForeignKey("dbo.Cursoes", t => t.CursoId, cascadeDelete: true)
                .ForeignKey("dbo.Materias", t => t.MateriaId, cascadeDelete: true)
                .ForeignKey("dbo.Profesors", t => t.ProfesorId, cascadeDelete: true)
                .Index(t => t.CarreraId)
                .Index(t => t.MateriaId)
                .Index(t => t.ProfesorId)
                .Index(t => t.CursoId);
            
            CreateTable(
                "dbo.Materias",
                c => new
                    {
                        MateriaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.MateriaId);
            
            CreateTable(
                "dbo.Profesors",
                c => new
                    {
                        ProfesorId = c.Int(nullable: false, identity: true),
                        LocalidadId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                    })
                .PrimaryKey(t => t.ProfesorId)
                .ForeignKey("dbo.Localidads", t => t.LocalidadId, cascadeDelete: true)
                .Index(t => t.LocalidadId);
            
            CreateTable(
                "dbo.Localidads",
                c => new
                    {
                        LocalidadId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.LocalidadId);
            
            CreateTable(
                "dbo.Estudiantes",
                c => new
                    {
                        EstudianteId = c.Int(nullable: false, identity: true),
                        LocalidadId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Telefono = c.String(),
                        Calle = c.String(),
                        Numero = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EstudianteId)
                .ForeignKey("dbo.Localidads", t => t.LocalidadId, cascadeDelete: true)
                .Index(t => t.LocalidadId);
            
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        PlanId = c.Int(nullable: false, identity: true),
                        CarreraId = c.Int(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.PlanId)
                .ForeignKey("dbo.Carreras", t => t.CarreraId, cascadeDelete: true)
                .Index(t => t.CarreraId);
            
            CreateTable(
                "dbo.Tipoes",
                c => new
                    {
                        TipoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.TipoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Plans", "CarreraId", "dbo.Carreras");
            DropForeignKey("dbo.Estudiantes", "LocalidadId", "dbo.Localidads");
            DropForeignKey("dbo.Detalles", "PlanillaId", "dbo.Planillas");
            DropForeignKey("dbo.Planillas", "ProfesorId", "dbo.Profesors");
            DropForeignKey("dbo.Profesors", "LocalidadId", "dbo.Localidads");
            DropForeignKey("dbo.Planillas", "MateriaId", "dbo.Materias");
            DropForeignKey("dbo.Planillas", "CursoId", "dbo.Cursoes");
            DropForeignKey("dbo.Planillas", "CarreraId", "dbo.Carreras");
            DropForeignKey("dbo.Detalles", "EstadoId", "dbo.Estadoes");
            DropIndex("dbo.Plans", new[] { "CarreraId" });
            DropIndex("dbo.Estudiantes", new[] { "LocalidadId" });
            DropIndex("dbo.Profesors", new[] { "LocalidadId" });
            DropIndex("dbo.Planillas", new[] { "CursoId" });
            DropIndex("dbo.Planillas", new[] { "ProfesorId" });
            DropIndex("dbo.Planillas", new[] { "MateriaId" });
            DropIndex("dbo.Planillas", new[] { "CarreraId" });
            DropIndex("dbo.Detalles", new[] { "EstadoId" });
            DropIndex("dbo.Detalles", new[] { "PlanillaId" });
            DropTable("dbo.Tipoes");
            DropTable("dbo.Plans");
            DropTable("dbo.Estudiantes");
            DropTable("dbo.Localidads");
            DropTable("dbo.Profesors");
            DropTable("dbo.Materias");
            DropTable("dbo.Planillas");
            DropTable("dbo.Estadoes");
            DropTable("dbo.Detalles");
            DropTable("dbo.Cursoes");
            DropTable("dbo.Carreras");
        }
    }
}

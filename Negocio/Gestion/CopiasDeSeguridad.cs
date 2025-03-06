using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Gestion
{
    public class CopiasDeSeguridad
    {
        private const string DefaultPath = @"C:\Backups";
        private const string SqlCreateBackup = "BACKUP DATABASE LabManager TO  DISK =  '@Path' WITH NOFORMAT, INIT, NAME = N'LabManager Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10";
        private const string SqlRestoreBackup =
            "USE [master] " +
            "ALTER DATABASE[LabManager] SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
            "RESTORE DATABASE[LabManager] FROM  DISK = N'@Path' WITH FILE = 1, MOVE N'LabManagerDesarrollo' TO N'@main', MOVE N'LabManagerDesarrollo_log' TO N'@log', NOUNLOAD, REPLACE, STATS = 5 " +
            "ALTER DATABASE[LabManager] SET MULTI_USER";
        //private string SqlHeader = "USE master;RESTORE HEADERONLY FROM DISK = N'@Path';";
        private string SqlFiles = "USE master;RESTORE FILELISTONLY FROM DISK = N'@Path';";

        public Dtos.Gestion.InformacionCopiasDeSeguridad getInformacionBackup (long UsuarioId)
        {
            var respuesta = new Dtos.Gestion.InformacionCopiasDeSeguridad();
            try
            {
                try
                {
                    var info = getBackupPath();
                    if (!System.IO.Directory.Exists(info.Path))
                    {
                        try
                        {
                            System.IO.Directory.CreateDirectory(info.Path);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("ERR03:"+ex.Message);
                        }
                    }
                    try
                    {
                        var directorio = new System.IO.DirectoryInfo(info.Path);
                        respuesta = new Dtos.Gestion.InformacionCopiasDeSeguridad()
                        {
                            Default = info.Default,
                            Error = false,
                            Mensaje = "",
                            Path = info.Path,
                            Archivos = directorio.GetFiles().OrderByDescending(f => f.Name).Take(10).Select(f => f.Name).ToArray()
                        };
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ER02:" + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("ER01:"+ex.Message);
                }
            }
            catch (Exception ex)
            {
                ex = Herramientas.ExtractException(ex);
                respuesta.Error = true;
                respuesta.Mensaje = ex.Message;
            }
            return respuesta;
        }

        public Dtos.DtoBase CreateBackup()
        {
            var respuesta = new Dtos.DtoBase();
            try
            {
                backup();
            }
            catch (Exception ex)
            {
                ex = Herramientas.ExtractException(ex);
                respuesta.Error = true;
                respuesta.Mensaje = ex.Message;
            }
            return respuesta;
        }
        private void backup()
        {
            var sqlcommand =
                        SqlCreateBackup.Replace("@Path", getBackupPath().Path + "\\LabManager_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm") + ".bak");
            using (var context = new Datos.LabManagerEntities())
            {
                context.Database.ExecuteSqlCommand(sqlcommand, new object[0]);
            }
        }
        public Dtos.DtoBase RestoreBackup(string file, long UserId)
        {
            backup();
            var respuesta = new Dtos.DtoBase();
            try
            {
                using (var context = new Datos.LabManagerEntities())
                {
                    var user = context.Usuarios.Where(u=>u.Activo&&u.TipoUsuarioId==0&&u.UsuarioId==UserId);
                    if (user.Count() != 1) throw new Exception("Este usuario no tiene permisos para restaurar la base de datos.");
                }
                var paths = getBackupPathFromFile(file);
                var datapath = paths[0].PhysicalName;
                var logpath = paths[1].PhysicalName;
                var infoPathData = new System.IO.FileInfo(datapath).DirectoryName;
                var infoPathLog = new System.IO.FileInfo(logpath).DirectoryName;

                if (!System.IO.Directory.Exists(infoPathData))
                {
                    System.IO.Directory.CreateDirectory(infoPathData);
                }
                if (!System.IO.Directory.Exists(infoPathLog))
                {
                    System.IO.Directory.CreateDirectory(infoPathLog);
                }

                var sqlcommand = 
                    SqlRestoreBackup.Replace("@Path", getBackupPath().Path + "\\" + file);
                sqlcommand = sqlcommand.Replace("@main",datapath);
                sqlcommand = sqlcommand.Replace("@log",logpath);
                using (var context = new Datos.LabManagerEntities())
                {
                    context.Database.ExecuteSqlCommand(sqlcommand, new object[0]);
                }
            }
            catch (Exception ex)
            {
                ex = Herramientas.ExtractException(ex);
                respuesta.Error = true;
                respuesta.Mensaje = ex.Message;
            }
            return respuesta;
        }

        private infopath getBackupPath()
        {
            try
            {
                using (var context = new Datos.LabManagerEntities())
                {
                    var path = context.Parametroes.Single(p => p.Nombre == "BackupPath");
                    return new infopath() { Path = path.Valor, Default = false };
                }
            }
            catch
            {
                return new infopath() { Path = DefaultPath, Default = true };
            }
        }
        private class infopath {
            public string Path { get; set; }
            public bool Default { get; set; }
        }
        private List<BackupFiles> getBackupPathFromFile(string file)//
        {
            string path = getBackupPath().Path + "\\" + file;
            using (var context = new Datos.LabManagerEntities())
            {
                var qry = SqlFiles.Replace("@Path",path);
                var result = context.Database.SqlQuery<BackupFiles>(qry,new object[0]).ToList();
                return result;
            }
        }
        private class BackupFiles {
            public string LogicalName { get; set; }
            public string PhysicalName { get; set; }
        }

    }
}

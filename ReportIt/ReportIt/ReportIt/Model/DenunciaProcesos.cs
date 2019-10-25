using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ReportIt.Model
{
    public class DenunciaProcesos
    {
        SQLiteAsyncConnection Database;
        public DenunciaProcesos()
        {
            string FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DenunciasDb.db");
            //Crear la conexion a la BD.
            Database = new SQLiteAsyncConnection(FilePath);
            //Crear Tablas ToDoItems.
            Database.CreateTableAsync<DenunciaModel>().Wait();
        }

        public Task<int> InsertarDenuncia(DenunciaModel _denunciaModel)
        {
            return Database.InsertAsync(_denunciaModel);
        }


        public Task<Model.DenunciaModel> ObtenerDenunciaPorId(int id)
        {
            //Select * from tablr where id == @id.
            return Database.Table<DenunciaModel>().Where(ti => ti.Id == id).FirstOrDefaultAsync();
        }



        //Actualizar Datos.
        public Task<int> ActualizarDenuncia(DenunciaModel _denunciaModel)
        {
            return Database.UpdateAsync(_denunciaModel);
        }



        //Borrar datos.
        public Task<int> BorrarDenuncia(DenunciaModel _denunciaModel)
        {
            return Database.DeleteAsync(_denunciaModel);
        }


        //Obtener todos los items de la tabala.
        public Task<List<DenunciaModel>> ObtenerTodasDenuncias()
        {
            //Select * from ToDoItemsDB.
            return Database.Table<DenunciaModel>().ToListAsync();
        }
    }
}

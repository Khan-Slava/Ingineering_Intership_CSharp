using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DLL
{
    public class Repository<T> : IRepository<T>
    {
        private readonly string path;

        public Repository(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new Exception("Путь в БД не может быть пустым");

            this.path = path;
        }

        //получить все объекты из бд 
        public ReturnResult<T> GetAll()
        {
            ReturnResult<T> result = new ReturnResult<T>();

            try
            {
                using (var db = new LiteDatabase(path))
                {
                    result.ListData = db.GetCollection<T>
                    (typeof(T).Name)
                        .FindAll()
                        .ToList();
                }
            }
            catch (LiteException ex)
                when (string.IsNullOrWhiteSpace(path))
            {
                result.Exception = ex;
                result.IsError = true;
            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.IsError = true;
            }

            return result;
        }

       
        //добавляет новый объект в бд
        public ReturnResult<T> Create(T data)
        {
            ReturnResult<T> result = new ReturnResult<T>();
            try
            {
                using (var db = new LiteDatabase(path))
                {
                    var list = db.GetCollection<T>
                        (typeof(T).Name);
                    list.Insert(data);
                }
            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.IsError = true;
            }
            return result;
        }

        
        //обновляет существующие объекты в бд
        public ReturnResult<T> Update(T data)
        {
            ReturnResult<T> result = new ReturnResult<T>();
            try
            {
                using (var db = new LiteDatabase(path))
                {
                    var list = db.GetCollection<T>
                        (typeof(T).Name);
                    list.Update(data);
                }
            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.IsError = true;
            }
            return result;
        }
    }
}

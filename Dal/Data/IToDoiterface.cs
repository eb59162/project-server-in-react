using ProjectReactServer.Models;
//using System.Data.Entity;
namespace Dal.Data
{
    public interface IToDointerface
    {
        //שליפה מכל הטבלאה
        Task<List<ToDoTable>> Get();
        //הוספה לטבלה
        Task <bool> Post(ToDoTable todotable);
        //עדכון לטבלה
        Task<bool> Put(int id, ToDoTable todotable);
        //מחיקה מהטבלה
        Task<bool> Delete(int id);

    }
}

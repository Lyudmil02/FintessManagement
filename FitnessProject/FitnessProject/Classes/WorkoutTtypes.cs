using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FitnessProject.Classes
{
    class WorkoutTtypes
    {
        Database.MYDB db = new Database.MYDB();

        //func to add workout
        public Boolean AddWorkout(string workoutType, string numEx, string description)
        {
            string query = "INSERT INTO [WorkoutType]([WorkoutType], [Exercises], [Descripton]) " +
                "VALUES(@WrT, @NumEx, @Desc)";

            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@WrT", SqlDbType.NVarChar);
            parameters[0].Value = workoutType;

            parameters[1] = new SqlParameter("@NumEx", SqlDbType.NVarChar);
            parameters[1].Value = numEx;

            parameters[2] = new SqlParameter("@Desc", SqlDbType.NVarChar);
            parameters[2].Value = description;

            if(db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //func to edit workout
        public Boolean EditWorkout(int id, string workoutType, string numEx, string description)
        {
            string query = "UPDATE [WorkoutType] SET [WorkoutType] = @WrT WHERE [Id] = @Id";

            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@Id", SqlDbType.Int);
            parameters[0].Value = id;

            parameters[1] = new SqlParameter("@WrT", SqlDbType.NVarChar);
            parameters[1].Value = workoutType;

            parameters[2] = new SqlParameter("@NumEx", SqlDbType.NVarChar);
            parameters[2].Value = numEx;

            parameters[3] = new SqlParameter("@Desc", SqlDbType.NVarChar);
            parameters[3].Value = description;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //func to remove workout
        public Boolean RemoveWorkout(int id)
        {
            string query = "DELETE FROM [WorkoutType] WHERE [Id] = @Id";

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Id", SqlDbType.Int);
            parameters[0].Value = id;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //func to return table
        public DataTable WorkoutTypesList()
        {
            DataTable table = new DataTable();
            table = db.getData("SELECT * FROM [WorkoutType]", null);

            return table;
        }
    }
}

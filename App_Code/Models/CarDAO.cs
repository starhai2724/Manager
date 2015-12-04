using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace Manager.Models
{ 
public class CarDAO
{
    public CarDAO()
    {
    }

        public int addCar(Car car)
        {
            string sql = "insert into dbo.Car(id_cus, license_plate, owner, type, producer,color, register_place,date_create, user_create, date_update, user_update, status) values( @id_cus, @license_plate, @owner, @type, @producer,@color, @register_place,@date_create, @user_create, @date_update, @user_update, @status)";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            

            // @id_cus, @license_plate, @owner, @type, @producer,@color, @register_place,@date_create, @user_create, @date_update, @user_update, @status
            // @, @, @, @, @, @,@color, @,@, @, @, @, @

            cmd.Parameters.AddWithValue("@id_cus", car.idCustomer);
            cmd.Parameters.AddWithValue("@license_plate", car.licensePlate);
            cmd.Parameters.AddWithValue("@owner", car.owner);
            cmd.Parameters.AddWithValue("@type", car.type);
            cmd.Parameters.AddWithValue("@producer", car.producer);
            cmd.Parameters.AddWithValue("@color", car.color);
            cmd.Parameters.AddWithValue("@register_place", car.registerPlace);
            cmd.Parameters.AddWithValue("@date_create", car.dateCreate);
            cmd.Parameters.AddWithValue("@user_create", car.userCreate);
            cmd.Parameters.AddWithValue("@date_update", car.dateUpdate);
            cmd.Parameters.AddWithValue("@user_update", car.userUpdate);
            cmd.Parameters.AddWithValue("@status", car.status);


            return GenericDataAccess.ExecuteNoneQuery(cmd);


        }
        public static List<Car> getCars()
        {
            string sql = "select * from Car";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            Car car;
            int id;
            int idCustomer;
            string licensePlate;
            string owner;
            string type;
            string producer;
            string color;
            string registerPlace;
            string dateCreate;
            string userCreate;
            string dateUpdate;
            string userUpdate;
            string status;

            List<Car> lst = new List<Car>();
            foreach (DataRow dr in dt.Rows)
            {
                 id= Convert.ToInt16(dr[0]);
                 idCustomer= Convert.ToInt16(dr[1]);
                 licensePlate= dr[2].ToString();
                 owner= dr[3].ToString();
                 type= dr[4].ToString();
                 producer= dr[5].ToString();
                 color= dr[6].ToString();
                 registerPlace= dr[7].ToString();
                 dateCreate= dr[8].ToString();
                 userCreate= dr[9].ToString();
                 dateUpdate= dr[10].ToString();
                 userUpdate= dr[11].ToString();
                 status= dr[12].ToString();

                car = new Car( id,  idCustomer,  licensePlate,  owner,  type,  producer,
                     color,  registerPlace,  dateCreate,
                     userCreate,  dateUpdate,  userUpdate,  status);
                lst.Add(car);
            }
            return lst;


        }

        //int id, int idCustomer, string licensePlate, string owner, string type, string producer, 
        //string color, string registerPlace, string dateCreate,
        // string userCreate, string dateUpdate, string userUpdate, string status

        // @, @, @, @, @,@, @,@date_create, @user_create, @date_update, @user_update, @status
        public int updateCar(Car car)
        {
            string sql = "update Car set id_cus=@id_cus, license_plate=@license_plate, owner=@owner, type=@type, producer=@producer, color=@color,register_place=@register_place,date_create=@date_create, user_create=@user_create,date_update=@date_update, user_update=@user_update,status=@status "
+ "Where id=@id";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.Parameters.AddWithValue("@id", car.id);
            cmd.Parameters.AddWithValue("@id_cus", car.idCustomer);
            cmd.Parameters.AddWithValue("@license_plate", car.licensePlate);
            cmd.Parameters.AddWithValue("@owner", car.owner);
            cmd.Parameters.AddWithValue("@type", car.type);
            cmd.Parameters.AddWithValue("@producer", car.producer);
            cmd.Parameters.AddWithValue("@color", car.color);
            cmd.Parameters.AddWithValue("@register_place", car.registerPlace);
            cmd.Parameters.AddWithValue("@date_create", car.dateCreate);
            cmd.Parameters.AddWithValue("@user_create", car.userCreate);
            cmd.Parameters.AddWithValue("@date_update", car.dateUpdate);
            cmd.Parameters.AddWithValue("@user_update", car.userUpdate);
            cmd.Parameters.AddWithValue("@status", car.status);
            return GenericDataAccess.ExecuteNoneQuery(cmd);



        }
        public static Car getCar(int id)
        {
            int idCustomer;
            string licensePlate;
            string owner;
            string type;
            string producer;
            string color;
            string registerPlace;
            string dateCreate;
            string userCreate;
            string dateUpdate;
            string userUpdate;
            string status;
            string sql = "select * from Car where id=@id";
            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@IdCustomer", id);
            DataTable dt = GenericDataAccess.ExecuteSelectCommand(cmd);
            foreach (DataRow dr in dt.Rows)
            {
                id = Convert.ToInt16(dr[0]);
                idCustomer = Convert.ToInt16(dr[1]);
                licensePlate = dr[2].ToString();
                owner = dr[3].ToString();
                type = dr[4].ToString();
                producer = dr[5].ToString();
                color = dr[6].ToString();
                registerPlace = dr[7].ToString();
                dateCreate = dr[8].ToString();
                userCreate = dr[9].ToString();
                dateUpdate = dr[10].ToString();
                userUpdate = dr[11].ToString();
                status = dr[12].ToString();

                return new Car(id, idCustomer, licensePlate, owner, type, producer,
                     color, registerPlace, dateCreate,
                     userCreate, dateUpdate, userUpdate, status);

            }
            return null;


        }

        public int deleteCar(int id)
        {

            string sql = "Delete from Car where id=@id";

            SqlCommand cmd = GenericDataAccess.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            return GenericDataAccess.ExecuteNoneQuery(cmd);



        }
    }
}
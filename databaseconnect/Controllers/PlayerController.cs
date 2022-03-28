using databaseconnect.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace databaseconnect.Controllers
{
    public class PlayerController : ApiController
    {

        public static string con = @"server = DESKTOP-K7K3O10\SQLEXPRESS; database=football;integrated security=true";
        //SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Klub", con);
        //SqlDataReader reader = command.ExecuteReader();
        //SqlConnection= new SqlConnection;
        // GET: api/Player

        [HttpGet]
        [Route("api/player")]


        // GET: api/Player
        public string Get()
        {
            {

                SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Player", con);
                DataTable datatable = new DataTable();
                data.Fill(datatable);
                if (datatable.Rows.Count > 0)
                {
                    return JsonConvert.SerializeObject(datatable);
                }
                else
                    return " No Data";

                // return new string[] { "value1", "value2" };


            }

        }


        //GET: api/Player/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Player
      
        [HttpPost]
        [Route("webapi/inserplayer")]
        //public void Post([FromBody] string value)
        //{
        public HttpResponseMessage InserNewPlayerWithAdapter(Player player)
        {
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Player", con);
            //SqlDataAdapter data = new SqlDataAdapter();
            SqlConnection connection = new SqlConnection(con);
            using (connection)
            {
                connection.Open();
                string newKlubCommand = $"INSERT INTO Klub ( Player Name, PlayerLastName, KlubName, PlayerPosition) VALUES ({player.PlayerName},{player.PlayerLastName}, {player.KlubName}, {player.PlayerPosition});";
                data.InsertCommand = new SqlCommand(newKlubCommand, connection);

                data.InsertCommand.ExecuteNonQuery();
                connection.Close();

            }
            return Request.CreateResponse(HttpStatusCode.OK, "You have inserted a new klub!");
        }
        //players.Add(newPLayer);
        // SqlDataAdapter data = new SqlDataAdapter("Inser * Into Player", con);
        // DataTable datatable = new DataTable();
        // data.Fill(datatable);


    }
}


        // PUT: api/Player/5
       /* public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Player/5
        public void Delete(int id)
        {
        }
    }*/

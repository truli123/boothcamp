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

       // public static string con = @"server = DESKTOP-K7K3O10\SQLEXPRESS; database=football;integrated security=true";
        static string connectionString = @"server = DESKTOP-K7K3O10\SQLEXPRESS; database=football;integrated security=true";
        SqlConnection con = new SqlConnection(connectionString);
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
        List<Player> InsertPlayer(Player player)
        {

            SqlCommand command = new SqlCommand
                ($"INSERT INTO Player (PlayerID, PlayerName, PlayerLastName, KLubName, PlayerPosition) VALUES ('{player.PlayerId}', '{player.PlayerName}'," +
                $" '{player.PlayerLastName}', '{player.KlubName}', '{player.PlayerPosition}');", con);

            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();


            SqlDataReader reader = command.ExecuteReader();
            Player plays= new Player();

            while ( reader.Read())
            {
                plays.PlayerId = reader.GetInt32(0);
                plays.PlayerName = reader.GetString(1);
                plays.PlayerLastName = reader.GetString(2);
                plays.KlubName = reader.GetString(3);
                plays.PlayerPosition = reader.GetString(4);
            }
            con.Close();
            return plays;

            
        }
            
        //public void Post([FromBody] string value)

      


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

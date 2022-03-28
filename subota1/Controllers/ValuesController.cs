using subota1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace subota1.Controllers
{
    public class PlayerController : ApiController 

    {
        static List<Player> players = new List<Player>();
        public PlayerController()
        {
            players.Add(new Player { PlayerName = " Pero", PlayerLastName = "peric", KlubName = "psv1", PlayerPosition = "Golakeeper", });
            players.Add(new Player { PlayerName = " Pera", PlayerLastName = "perica", KlubName = "psv2", PlayerPosition = "Golakeeper", });
            players.Add(new Player { PlayerName = " Peru", PlayerLastName = "pericaa", KlubName = "psv3", PlayerPosition = "Golakeeper", });
            //"New York","London","Mumbai","Chicago"};

            // GET api/values

        }
        [HttpGet]
        [Route("api/values/PlayerName")]
        public List <string> GetPlayerNames()
        {
            List<string> names = new List<string>();
           foreach (var Player in players)
            {
                names.Add(Player.PlayerName);
            }
            return names;// return cities;
        }

        // GET api/values/5
        [HttpGet]
        [Route("api/values/player")]
        public string  Get(int id)
        {
            return "players";
        }
      
        // POST api/values
        //public void Post([FromBody] string value)
        [HttpPost]
        [Route("api/values/Player")]
        
            public string InsertNewPlayer(Player newPlayer)
            {
                players.Add(newPlayer);
                Player player = new Player();
                player.PlayerName = players.Last().PlayerName;
                player.PlayerLastName = players.Last().PlayerLastName;
                player.KlubName = players.Last().KlubName;
                player.PlayerPosition = players.Last().PlayerPosition;
                player.PlayerId = players.Last().PlayerId;
                return $"A new Player {player.PlayerName} {player.PlayerLastName} {player.KlubName}  {player.PlayerPosition}";
            }
        

        // PUT api/values/5
       /* public void Put(int id, [FromBody] string value)
        {
            players[id] = Player; 
        }*/

        // DELETE api/values/5
        public void Delete(int id)
        {
            //cities.RemoveAt(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace databaseconnect.Controllers
{
    public class ValuesController : ApiController
    {
        public SqlConnection con = new SqlConnection(@"server = DESKTOP-K7K3O10\SQLEXPRESS; database=Football;integrated security=true;");
        public string Get()
        {

            SqlDataAdapter tata = new SqlDataAdapter("SELECT * FROM Klub", con);
            DataTable datatable = new DataTable();
            tata.Fill(datatable);
            if (datatable.Rows.Count > 0)
            {
                return JsonConvert.SerializeObject(datatable);
            }
            else
                return " No Data";

            // return new string[] { "value1", "value2" };


        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }
    }
}


    // POST api/values
    //[HttpPost]
    //[Route("WebApi/klubinsert")]
  /*         public void Post([FromBody] string value)
    {
       SqlConnection con = new SqlConnection(@"server = DESKTOP-K7K3O10\SQLEXPRESS; database=Football;integrated security=true;");
        SqlCommand command;
        SqlDataAdapter data = new SqlDataAdapter("Insert Into KLub", con);
        String sql = "";
        String Output = "";
        sql = "INSERT INTO Klub ( KlubId, KlubName, KlubCityName, KlubCountryName)";
        command = new SqlCommand(sql, con);
        //7adapter.InsertCommand = SqlCommand(sql, con);
        using (SqlDataReader dataReader = command.ExecuteReader())
        {
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetInt32(0) + dataReader.GetString(1) + dataReader.GetString(2)
                + dataReader.GetString(3);
            }


            con.Open();
            con.Close();


        }
    }
}*/
    /*
        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}*/

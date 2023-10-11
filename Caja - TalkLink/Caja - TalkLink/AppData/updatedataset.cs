using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja___TalkLink
{
    public class DataSetUpdater
    {
        public void UpdateDataSet(DataSet dataset)
        {
            string selectQuery = "SELECT * FROM Clientes";
            string connectionString = ConfigurationManager.ConnectionStrings["TLDataset"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Crear un SqlDataAdapter para obtener los datos de la base de datos
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);

                // Llenar el DataSet con los datos de la base de datos
                adapter.Fill(dataset, "Clientes");

                // Marcar los cambios como confirmados en el DataSet
                dataset.Tables["Clientes"].AcceptChanges();
            }
        }
    }
}

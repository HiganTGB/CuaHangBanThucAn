using CuaHangBanThucAn.LIB.Error;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangBanThucAn.DAO
{
    public class DataProvider
    {
        private static string connectionString = "Data Source=HIGAN\\HIGAN;Initial Catalog=QuanLiBanThucAn;Persist Security Info=True;User ID=HIGAN;Password=123";

        public DataProvider()
        {

        }

        public static DataTable ExecuteQuery(string query)
        {
            try
            {
                try
                {
                    // Tạo một đối tượng SqlConnection
                    SqlConnection connection = new SqlConnection(connectionString);

                    // Mở kết nối với cơ sở dữ liệu
                    connection.Open();
                    if (connection == null)
                    {
                        throw new AppException(404, "Lỗi kết nối sql");
                    }
                    // Tạo một đối tượng SqlCommand
                    SqlCommand command = new SqlCommand(query, connection);

                    // Tạo một đối tượng SqlDataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    // Tạo một đối tượng DataTable
                    DataTable dataTable = new DataTable();

                    // Điền dữ liệu từ SqlCommand vào DataTable
                    adapter.Fill(dataTable);

                    // Đóng kết nối với cơ sở dữ liệu
                    connection.Close();

                    // Trả về DataTable
                    return dataTable;
                }
            catch (SqlException ex)
            {
                throw new AppException(405, string.Format("Lỗi query SQL kìa \n{0}", query));
            } }
            catch (AppException ex)
            {
                throw ex;
            }
        }

        public static int ExecuteNonQuery(string query)
        {
            try
            {
            // Tạo một đối tượng SqlConnection
            SqlConnection connection = new SqlConnection(connectionString);

            // Mở kết nối với cơ sở dữ liệu
            connection.Open();
            if (connection == null)
            {
                throw new AppException(404, "Lỗi kết nối sql");
            }
            // Tạo một đối tượng SqlCommand
            SqlCommand command = new SqlCommand(query, connection);

            // Thực hiện truy vấn dữ liệu
            int affectedRows = command.ExecuteNonQuery();

            // Đóng kết nối với cơ sở dữ liệu
            connection.Close();

            return affectedRows;
            }
            catch (SqlException ex)
            {
                throw new AppException(405, string.Format("Lỗi query SQL kìa \n{0}", query));
            }
            catch (AppException ex)
            {
                throw ex;
            }
        }

        public static object ExecuteScalar(string query)
        {
            try
            {
                // Tạo một đối tượng SqlConnection
                SqlConnection connection = new SqlConnection(connectionString);

                // Mở kết nối với cơ sở dữ liệu
                connection.Open();
                if (connection == null)
                {
                    throw new AppException(404, "Lỗi kết nối sql");
                }
                // Tạo một đối tượng SqlCommand
                SqlCommand command = new SqlCommand(query, connection);

                // Thực hiện truy vấn dữ liệu
                object scalar = command.ExecuteScalar();

                // Đóng kết nối với cơ sở dữ liệu
                connection.Close();

                return scalar;
            }
            catch (SqlException ex)
            {
                throw new AppException(405, string.Format("Lỗi query SQL kìa \n{0}", query));
            }
            catch (AppException ex)
            {
                throw ex;
            }
        }
    }

}

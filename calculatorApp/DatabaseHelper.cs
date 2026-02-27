using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace calculatorApp
{
    internal class DatabaseHelper
    {
        private string connString = "Host=localhost; Port=5432; Username=postgres; Password=password123; Database=my_calculator_db";

        public bool CheckLogin(string user, string pass)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string sql = "SELECT COUNT(*) FROM users WHERE username = @u AND password = @p";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("u", user);
                        cmd.Parameters.AddWithValue("p", pass);

                        long count = (long)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // DB接続自体に失敗した場合はエラーを表示
                System.Windows.Forms.MessageBox.Show("DBエラー: " + ex.Message);
                return false;
            }
        }
        public void SaveHistory(string user, string formula, string result)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "INSERT INTO calculation_history (username, formula, result) VALUES (@u, @f, @r)";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("u", user);
                    cmd.Parameters.AddWithValue("f", formula);
                    cmd.Parameters.AddWithValue("r", result);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

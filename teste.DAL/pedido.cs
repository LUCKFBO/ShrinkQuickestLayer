using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace teste.DAL
{
		/// <summary>
		/// Camada de Acesso de Dados
		/// É uma camada separada da camada da apresentação de dados
		/// que tem a função de efetuar a conexão com a fonte de dados e através de
		/// comandos SQL (neste nosso caso) obter os dados para apresentação.
		/// </summary>
	public class pedido: IDisposable
	{
		String _conexaoSQL = "";
		SqlConnection conn = null;

		public pedido()
		{
			_conexaoSQL = conf.Default.ConnectionString;
		}

		public List<DTO.pedido> GetList( )
		{
			try
			{
				String sql = "SELECT * FROM pedido";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				conn.Open();
				List<DTO.pedido> lista = new List<DTO.pedido>();
				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					while (dr.Read())
					{
						DTO.pedido dto = new DTO.pedido();
						dto.id = Convert.ToInt32(dr["id"]);
						dto.id_cliente = Convert.ToInt32(dr["id_cliente"]);
						dto.total = (dr["total"] != DBNull.Value) ? (double?)(dr["total"]) : null;
						lista.Add(dto);
					}
				}
				return lista;
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		public List<DTO.pedido> GetListByID(DTO.pedido VAR)
		{
			try
			{
				String sql = "SELECT * FROM pedido WHERE id = @VAR0  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@VAR0", VAR.id);
				conn.Open();
				List<DTO.pedido> lista = new List<DTO.pedido>();
				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					while (dr.Read())
					{
						DTO.pedido dto = new DTO.pedido();
						dto.id = Convert.ToInt32(dr["id"]);
						dto.id_cliente = Convert.ToInt32(dr["id_cliente"]);
						dto.total = (dr["total"] != DBNull.Value) ? (double?)(dr["total"]) : null;
						lista.Add(dto);
					}
				}
				return lista;
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		public void Insert(DTO.pedido dto)
		{
			try
			{
				String sql = "INSERT INTO pedido (id_cliente, data_pedido, total) VALUES (@id_cliente, @data_pedido, @total)";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@id", dto.id);
				cmd.Parameters.AddWithValue("@id_cliente", dto.id_cliente);
				cmd.Parameters.AddWithValue("@data_pedido", dto.data_pedido);
				cmd.Parameters.AddWithValue("@total", dto.total == null ? (object)DBNull.Value : dto.total);
				conn.Open();
				cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		public void Update(DTO.pedido dto)
		{
			try
			{
				String sql = "UPDATE pedido SET id_cliente = @id_cliente, data_pedido = @data_pedido, total = @total WHERE id = @DTO4  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@DTO4", dto.id);
				cmd.Parameters.AddWithValue("@id", dto.id);
				cmd.Parameters.AddWithValue("@id_cliente", dto.id_cliente);
				cmd.Parameters.AddWithValue("@data_pedido", dto.data_pedido);
				cmd.Parameters.AddWithValue("@total", dto.total == null ? (object)DBNull.Value : dto.total);
				conn.Open();
				cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		public void Delete(DTO.pedido dto)
		{
			try
			{
				String sql = "DELETE FROM pedido WHERE id = @DTO8  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@DTO8", dto.id);
				conn.Open();
				cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		public DataTable GetDataTable( )
		{
			try
			{
				String sql = "SELECT * FROM pedido";
				conn = new SqlConnection(_conexaoSQL);
				conn.Open();
				SqlCommand cmd = new SqlCommand(sql, conn);
				SqlDataAdapter da = new SqlDataAdapter();
				da.SelectCommand = cmd;
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		public DataTable GetDataTableByID(DTO.pedido VAR)
		{
			try
			{
				String sql = "SELECT * FROM pedido WHERE id = @VAR12  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@VAR12", VAR.id);
				conn.Open();
				SqlDataAdapter da = new SqlDataAdapter();
				da.SelectCommand = cmd;
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		public DataTable GetDataTableJoin( )
		{
			try
			{
				String sql = "SELECT * FROM pedido JOIN cliente t0 ON pedido.id_cliente = t0.id";
				conn = new SqlConnection(_conexaoSQL);
				conn.Open();
				SqlCommand cmd = new SqlCommand(sql, conn);
				SqlDataAdapter da = new SqlDataAdapter();
				da.SelectCommand = cmd;
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		public DataTable GetDataTableJoinByID(DTO.pedido VAR)
		{
			try
			{
				String sql = "SELECT * FROM pedido JOIN cliente t0 ON pedido.id_cliente = t0.id WHERE pedido.id = @VAR16  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@VAR16", VAR.id);
				conn.Open();
				SqlDataAdapter da = new SqlDataAdapter();
				da.SelectCommand = cmd;
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		public List<DTO.pedido> GetListJoinByID(DTO.pedido VAR)
		{
			try
			{
				String sql = "SELECT * FROM pedido JOIN cliente t0 ON pedido.id_cliente = t0.id WHERE pedido.id = @VAR20  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@VAR20", VAR.id);
				conn.Open();
				List<DTO.pedido> lista = new List<DTO.pedido>();
				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					while (dr.Read())
					{
						DTO.pedido dto = new DTO.pedido();
						dto.id = Convert.ToInt32(dr[0]);
						dto.id_cliente = Convert.ToInt32(dr[1]);
						dto.total = (dr[3] != DBNull.Value) ? (double?)(dr[3]) : null;
						DTO.cliente dto0 = new DTO.cliente();
						dto0.id = Convert.ToInt32(dr[4]);
						dto0.nome = Convert.ToString(dr[5]);
						dto0.email = Convert.ToString(dr[6]);
						dto0.senha = Convert.ToString(dr[7]);
						dto0.id_contato = (dr[8] != DBNull.Value) ? (Int32?)(dr[8]) : null;
						dto.cliente.Add(dto0);
						lista.Add(dto);
					}
				}
				return lista;
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}
		}
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				conn.Dispose();
			}
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}

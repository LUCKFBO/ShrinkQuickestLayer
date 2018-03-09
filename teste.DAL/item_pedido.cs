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
	public class item_pedido: IDisposable
	{
		String _conexaoSQL = "";
		SqlConnection conn = null;

		public item_pedido()
		{
			_conexaoSQL = conf.Default.ConnectionString;
		}

		public List<DTO.item_pedido> GetList( )
		{
			try
			{
				String sql = "SELECT * FROM item_pedido";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				conn.Open();
				List<DTO.item_pedido> lista = new List<DTO.item_pedido>();
				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					while (dr.Read())
					{
						DTO.item_pedido dto = new DTO.item_pedido();
						dto.id_pedido = Convert.ToInt32(dr["id_pedido"]);
						dto.id_produto = Convert.ToInt32(dr["id_produto"]);
						dto.preco_unitario = Convert.ToDouble(dr["preco_unitario"]);
						dto.quantidade = Convert.ToInt32(dr["quantidade"]);
						dto.preco_total = Convert.ToDouble(dr["preco_total"]);
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
		public List<DTO.item_pedido> GetListByID(DTO.item_pedido VAR)
		{
			try
			{
				String sql = "SELECT * FROM item_pedido WHERE id_pedido = @VAR0 AND id_produto = @VAR1  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@VAR0", VAR.id_pedido);
				cmd.Parameters.AddWithValue("@VAR1", VAR.id_produto);
				conn.Open();
				List<DTO.item_pedido> lista = new List<DTO.item_pedido>();
				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					while (dr.Read())
					{
						DTO.item_pedido dto = new DTO.item_pedido();
						dto.id_pedido = Convert.ToInt32(dr["id_pedido"]);
						dto.id_produto = Convert.ToInt32(dr["id_produto"]);
						dto.preco_unitario = Convert.ToDouble(dr["preco_unitario"]);
						dto.quantidade = Convert.ToInt32(dr["quantidade"]);
						dto.preco_total = Convert.ToDouble(dr["preco_total"]);
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
		public void Insert(DTO.item_pedido dto)
		{
			try
			{
				String sql = "INSERT INTO item_pedido (id_pedido, id_produto, preco_unitario, quantidade, preco_total) VALUES (@id_pedido, @id_produto, @preco_unitario, @quantidade, @preco_total)";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@id_pedido", dto.id_pedido);
				cmd.Parameters.AddWithValue("@id_produto", dto.id_produto);
				cmd.Parameters.AddWithValue("@preco_unitario", dto.preco_unitario);
				cmd.Parameters.AddWithValue("@quantidade", dto.quantidade);
				cmd.Parameters.AddWithValue("@preco_total", dto.preco_total);
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
		public void Update(DTO.item_pedido dto)
		{
			try
			{
				String sql = "UPDATE item_pedido SET id_pedido = @id_pedido, id_produto = @id_produto, preco_unitario = @preco_unitario, quantidade = @quantidade, preco_total = @preco_total WHERE id_pedido = @DTO5 AND id_produto = @DTO6  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@DTO5", dto.id_pedido);
				cmd.Parameters.AddWithValue("@id_pedido", dto.id_pedido);
				cmd.Parameters.AddWithValue("@DTO6", dto.id_produto);
				cmd.Parameters.AddWithValue("@id_produto", dto.id_produto);
				cmd.Parameters.AddWithValue("@preco_unitario", dto.preco_unitario);
				cmd.Parameters.AddWithValue("@quantidade", dto.quantidade);
				cmd.Parameters.AddWithValue("@preco_total", dto.preco_total);
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
		public void Delete(DTO.item_pedido dto)
		{
			try
			{
				String sql = "DELETE FROM item_pedido WHERE id_pedido = @DTO10 AND id_produto = @DTO11  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@DTO10", dto.id_pedido);
				cmd.Parameters.AddWithValue("@DTO11", dto.id_produto);
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
				String sql = "SELECT * FROM item_pedido";
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
		public DataTable GetDataTableByID(DTO.item_pedido VAR)
		{
			try
			{
				String sql = "SELECT * FROM item_pedido WHERE id_pedido = @VAR15 AND id_produto = @VAR16  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@VAR15", VAR.id_pedido);
				cmd.Parameters.AddWithValue("@VAR16", VAR.id_produto);
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
				String sql = "SELECT * FROM item_pedido JOIN pedido t0 ON item_pedido.id_pedido = t0.id JOIN produto t1 ON item_pedido.id_produto = t1.id";
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
		public DataTable GetDataTableJoinByID(DTO.item_pedido VAR)
		{
			try
			{
				String sql = "SELECT * FROM item_pedido JOIN pedido t0 ON item_pedido.id_pedido = t0.id JOIN produto t1 ON item_pedido.id_produto = t1.id WHERE item_pedido.id_pedido = @VAR20 AND item_pedido.id_produto = @VAR21  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@VAR20", VAR.id_pedido);
				cmd.Parameters.AddWithValue("@VAR21", VAR.id_produto);
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
		public List<DTO.item_pedido> GetListJoinByID(DTO.item_pedido VAR)
		{
			try
			{
				String sql = "SELECT * FROM item_pedido JOIN pedido t0 ON item_pedido.id_pedido = t0.id JOIN produto t1 ON item_pedido.id_produto = t1.id WHERE item_pedido.id_pedido = @VAR25 AND item_pedido.id_produto = @VAR26  ";
				conn = new SqlConnection(_conexaoSQL);
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@VAR25", VAR.id_pedido);
				cmd.Parameters.AddWithValue("@VAR26", VAR.id_produto);
				conn.Open();
				List<DTO.item_pedido> lista = new List<DTO.item_pedido>();
				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					while (dr.Read())
					{
						DTO.item_pedido dto = new DTO.item_pedido();
						dto.id_pedido = Convert.ToInt32(dr[0]);
						dto.id_produto = Convert.ToInt32(dr[1]);
						dto.preco_unitario = Convert.ToDouble(dr[2]);
						dto.quantidade = Convert.ToInt32(dr[3]);
						dto.preco_total = Convert.ToDouble(dr[4]);
						DTO.pedido dto0 = new DTO.pedido();
						dto0.id = Convert.ToInt32(dr[5]);
						dto0.id_cliente = Convert.ToInt32(dr[6]);
						dto0.total = (dr[8] != DBNull.Value) ? (double?)(dr[8]) : null;
						dto.pedido.Add(dto0);
						DTO.produto dto1 = new DTO.produto();
						dto1.id = Convert.ToInt32(dr[9]);
						dto1.titulo = Convert.ToString(dr[10]);
						dto1.descricao = (dr[11] != DBNull.Value) ? Convert.ToString(dr[11]) : null;
						dto1.preco = Convert.ToDouble(dr[12]);
						dto1.imagem = (dr[13] != DBNull.Value) ? (Byte?[])(dr[13]) : null;
						dto.produto.Add(dto1);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace ADODesconectado3
{
	public class Gestor
	{
		string connectionstring = @"Data Source=MM;Initial Catalog=Kati;Integrated Security=True";

		#region Campos Generales
		DataSet dataset;
		SqlConnection conexion;
		DataRelation relacion;
		#endregion

		#region Campos para Persona
		SqlDataAdapter AdapterPersona;
		SqlCommandBuilder CommandBuilderPersona;
		DataTable TablePersona;
		DataView ViewPersona;
		#endregion

		#region Campos para Telefono
		DataTable TableTelefono;
		SqlCommandBuilder CommandBuilderTelefono;
		DataView ViewTelefono;
		SqlDataAdapter AdapterTelefono;
		#endregion

		public Gestor()
		{
			dataset = new DataSet();
			conexion = new SqlConnection(connectionstring);
			CrearTablePersona();
			CrearTableTelefono();
			CrearRelation();
			CargarPK();
		}

		public void CrearTablePersona()
		{
			AdapterPersona = new SqlDataAdapter( "select* from Persona", conexion);
			CommandBuilderPersona = new SqlCommandBuilder(AdapterPersona);
			AdapterPersona.InsertCommand = CommandBuilderPersona.GetInsertCommand();
			AdapterPersona.DeleteCommand = CommandBuilderPersona.GetDeleteCommand();
			AdapterPersona.UpdateCommand = CommandBuilderPersona.GetUpdateCommand();
			AdapterPersona.Fill(dataset, "Persona");
		}

		public void CrearTableTelefono()
		{
			TableTelefono = new DataTable("Telefono");
			AdapterTelefono = new SqlDataAdapter("select * from Telefono", conexion);
			CommandBuilderTelefono = new SqlCommandBuilder(AdapterTelefono);
			AdapterTelefono.InsertCommand = CommandBuilderTelefono.GetInsertCommand();
			AdapterTelefono.DeleteCommand = CommandBuilderTelefono.GetDeleteCommand();
			AdapterTelefono.UpdateCommand = CommandBuilderTelefono.GetUpdateCommand();
			dataset.Tables.Add(TableTelefono);
			AdapterTelefono.Fill(dataset, "Telefono");
		}

		public void CrearRelation()
		{
			DataColumn primary = TablePersona.Columns["codigo_persona"];
			DataColumn foreign = TableTelefono.Columns["codigo_telefono"];
			relacion = new DataRelation("persona_telefono", primary, foreign);
			dataset.Relations.Add(relacion);
		}

		public void CargarPK()
		{
			DataColumn primarypersona = TablePersona.Columns["codigo_persona"];
			TablePersona.PrimaryKey = new DataColumn[] { primarypersona };

			DataColumn primarytelefono = TableTelefono.Columns["codigo_telefono"];
			TableTelefono.PrimaryKey = new DataColumn[] { primarytelefono };
		}

		#region ABMC Persona

		public void AgregarPersona(Persona persona)
		{
			DataRow rowalta = TablePersona.NewRow();
			rowalta["codigo_persona"] = persona.Codigo;
			rowalta["nombreper"] = persona.Nombre;
			rowalta["apellidoper"] = persona.Apellido;
			TablePersona.Rows.Add(rowalta);
			AdapterPersona.Update(TablePersona);
			TablePersona.AcceptChanges();
		}

		public void EliminarPersona(Persona persona)
		{
			DataRow rowbaja = TablePersona.Rows.Find(persona.Codigo);
			rowbaja.Delete();
			AdapterPersona.Update(TablePersona);
			TablePersona.AcceptChanges();
		}

		public void ModificarPersona(Persona persona)
		{
			DataRow rowmod = TablePersona.Rows.Find(persona.Codigo);
			rowmod["codigo_persona"] = persona.Codigo;
			rowmod["nombreper"] = persona.Nombre;
			rowmod["apellidoper"] = persona.Apellido;
			AdapterPersona.Update(TablePersona);
			TablePersona.AcceptChanges();
		}

		public List<Persona> VerPersonas()
		{
			List<Persona> laspersonas = new List<Persona>();
			ViewPersona = new DataView(TablePersona, "", "", DataViewRowState.CurrentRows);
			foreach (DataRowView rowview in ViewPersona)
			{
				DataRow row = rowview.Row;
				int c = int.Parse(row["codigo_persona"].ToString());
				string n = row["nombreper"].ToString();
				string a = row["apellidoper"].ToString();
				Persona p = new Persona();
				p.Codigo = c; p.Nombre = n; p.Apellido = a;
				laspersonas.Add(p);
			}
			return laspersonas;
		}

		public List<Telefono> VerPersonaTelefonos(Persona persona)
		{
			List<Telefono> lostelefonos = new List<Telefono>();
			DataRow[] rowtelefonos = TablePersona.Rows.Find(persona.Codigo).GetChildRows("persona_telefono");
			foreach (DataRow row in rowtelefonos)
			{
				int c = int.Parse(row["codigo_telefono"].ToString());
				int n = int.Parse(row["numerotel"].ToString());
				Telefono t = new Telefono();
				t.Codigo = c; t.Numero = n;
				lostelefonos.Add(t);
			}
			return lostelefonos;
		}
		#endregion

		#region ABMC Telefonos

		public void AgregarTelefono(Telefono telefono, Persona persona)
		{
			DataRow rowalta = TableTelefono.NewRow();
			rowalta["codigo_telefono"] = telefono.Codigo;
			rowalta["numerotel"] = telefono.Numero;
			rowalta["codpersonatel"] = persona.Codigo;
			TableTelefono.Rows.Add(rowalta);
			AdapterTelefono.Update(TableTelefono);
			TableTelefono.AcceptChanges();
		}

		public void EliminarTelefono(Telefono telefono)
		{
			DataRow rowbaja = TableTelefono.Rows.Find(telefono.Codigo);
			rowbaja.Delete();
			AdapterTelefono.Update(TableTelefono);
			TableTelefono.AcceptChanges();
		}

		public void ModificarTelefono(Telefono telefono)
		{
			DataRow rowmod = TableTelefono.Rows.Find(telefono.Codigo);
			rowmod["codigo_telefono"] = telefono.Codigo;
			rowmod["numerotel"] = telefono.Numero;
			AdapterTelefono.Update(TableTelefono);
			TableTelefono.AcceptChanges();
		}

		public List<Telefono> VerTelefonos()
		{
			List<Telefono> lostelefonos = new List<Telefono>();
			ViewTelefono = new DataView(TableTelefono, "", "", DataViewRowState.CurrentRows);
			foreach (DataRowView rowview in ViewTelefono)
			{
				DataRow row = rowview.Row;
				int c = int.Parse(row["codigo_telefono"].ToString());
				int n = int.Parse(row["numerotel"].ToString());
				Telefono t = new Telefono();
				t.Codigo = c; t.Numero = n;
				lostelefonos.Add(t);
			}
			return lostelefonos;
		}
		#endregion
	}
}

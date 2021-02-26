using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DesconectadoPractica3
{
    class Gestor
    {
        string connectionString = @"Data Source=MM;Initial Catalog=Kati;Integrated Security=True";
        DataSet dataSet;
        SqlConnection conexion;
        DataRelation relacionPersonaTelefono;

        SqlDataAdapter adapterPersona;
        SqlCommandBuilder commandPersona;
        DataView viewPersona;
        DataTable tablePersona;

        SqlDataAdapter adapterTelefono;
        SqlCommandBuilder commandTelefono;
        DataView viewTelefono;
        DataTable tableTelefono;

        public Gestor()
        {
            dataSet = new DataSet();
            conexion = new SqlConnection(connectionString);
            CrearTablaPersona();
            CrearTablaTelefono();
            CrearRelacion();
        }

        public void CrearTablaPersona()
        {
            tablePersona = new DataTable("Persona");
            adapterPersona = new SqlDataAdapter("Select * From Persona", conexion);
            commandPersona = new SqlCommandBuilder(adapterPersona);
            adapterPersona.InsertCommand = commandPersona.GetInsertCommand();
            adapterPersona.UpdateCommand = commandPersona.GetUpdateCommand();
            adapterPersona.DeleteCommand = commandPersona.GetDeleteCommand();
            dataSet.Tables.Add(tablePersona);
            adapterPersona.Fill(dataSet, "Persona");
        }

        public void CrearTablaTelefono()
        {
            tableTelefono = new DataTable("Telefono");
            adapterTelefono = new SqlDataAdapter("Select * From Telefono", conexion);
            commandTelefono = new SqlCommandBuilder(adapterTelefono);
            adapterTelefono.InsertCommand = commandTelefono.GetInsertCommand();
            adapterTelefono.UpdateCommand = commandTelefono.GetUpdateCommand();
            adapterTelefono.DeleteCommand = commandTelefono.GetDeleteCommand();
            dataSet.Tables.Add(tableTelefono);
            adapterTelefono.Fill(dataSet, "Telefono");
        }

        public void CrearRelacion()
        {
            DataColumn padre = tablePersona.Columns["codigo_persona"];
            DataColumn hijo = tableTelefono.Columns["codpersonatel"];
            relacionPersonaTelefono = new DataRelation("PersonaTelefono", padre, hijo);
            dataSet.Relations.Add(relacionPersonaTelefono);
        }

        public void AltaPersona(Persona p)
        {
            DataRow agregar = tablePersona.NewRow();
            agregar["codigo_persona"] = p.codigo;
            agregar["nombreper"] = p.nombre;
            agregar["apellidoper"] = p.apellido;
            tablePersona.Rows.Add(agregar);
            adapterPersona.Update(tablePersona);
            tablePersona.AcceptChanges();
        }

        public void ModificarPersona(Persona p)
        {
            DataRow modificar = tablePersona.Rows.Find(p.codigo);
            modificar["codigo_persona"] = p.codigo;
            modificar["nombreper"] = p.nombre;
            modificar["apellidoper"] = p.apellido;
            adapterPersona.Update(tablePersona);
            tablePersona.AcceptChanges();
        }

        public void BajaPersona(Persona p)
        {
            tablePersona.Rows.Find(p.codigo).Delete();
            adapterPersona.Update(tablePersona);
            tablePersona.AcceptChanges();
        }

        public List<Persona> ListaPersona()
        {
            List<Persona> personas = new List<Persona>();
            viewPersona = new DataView(tablePersona, "", "", DataViewRowState.CurrentRows);
            foreach (DataRowView dataRV in viewPersona)
            {
                DataRow r = dataRV.Row;
                personas.Add(new Persona(int.Parse(r[0].ToString()), r[1].ToString(), r[2].ToString()));
            }
            return personas;
        }

        public List<Telefono> ListaPersonaTelefono(Persona p)
        {
            List<Telefono> telefonos = new List<Telefono>();
            DataRow[] rowTelefonos = tablePersona.Rows.Find(p.codigo).GetChildRows("PersonaTelefono");
            foreach (DataRow r in rowTelefonos)
            {
                telefonos.Add(new Telefono(int.Parse(r[0].ToString()), r[1].ToString()));
            }
            return telefonos;
        }

        public void AltaTelefono(Telefono t, Persona p)
        {
            DataRow agregar = tableTelefono.NewRow();
            agregar["codigo_telefono"] = t.codigo;
            agregar["numerotel"] = t.numero;
            agregar["codpersonatel"] = p.codigo;
            tableTelefono.Rows.Add(agregar);
            adapterTelefono.Update(tableTelefono);
            tableTelefono.AcceptChanges();
        }

        public void ModificarTelefono(Telefono t)
        {
            DataRow modificar = tableTelefono.Rows.Find(t.codigo);
            modificar["codigo_telefono"] = t.codigo;
            modificar["numerotel"] = t.numero;
            adapterTelefono.Update(tableTelefono);
            tableTelefono.AcceptChanges();
        }

        public void BajaTelefono(Telefono t)
        {
            tableTelefono.Rows.Find(t.codigo).Delete();
            adapterTelefono.Update(tableTelefono);
            tableTelefono.AcceptChanges();
        }

        public List<Telefono> ListaTelefono()
        {
            List<Telefono> telefonos = new List<Telefono>();
            viewTelefono = new DataView(tableTelefono, "", "", DataViewRowState.CurrentRows);
            foreach (DataRowView dataRV in viewTelefono)
            {
                DataRow r = dataRV.Row;
                telefonos.Add(new Telefono(int.Parse(r[0].ToString()), r[1].ToString()));
            }
            return telefonos;
        }
    }
}

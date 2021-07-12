using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace ptoVenta
{
    public partial class devoluciones : Form
    {
        SqlCommand com;
        SqlDataReader dr;

        private string comsql1, comsql2;
        private double prec, cant, tot = 0, totd = 0;

        public devoluciones()
        {
            InitializeComponent();
        }

        private void devoluciones_Load(object sender, EventArgs e)
        {
            txtBoletaFactura.Text = ticketsEmitidos.vnum;
            comsql1 = "SELECT F.NUMERO,C.NOMBRE,M.FECHA,M.CODIGO,M.DESCRIP,M.CANTIDAD,M.MONTOFINAL FROM CAJAS C RIGHT JOIN FACTURAS F ON C.CODIGO = F.CAJAPERTUR ";
            comsql2 = comsql1 + "LEFT JOIN MFACTURAS M ON M.NUMERO = F.NUMERO WHERE F.STATUS=2 AND M.NUMERO='" + ticketsEmitidos.vnum + "'  ORDER BY M.POSI ";
            com = new SqlCommand(comsql2, Form1.cn);
            com.ExecuteNonQuery();
            dr = com.ExecuteReader();
            dgvGrid1.Rows.Clear();
            int fila = 0;
            while (dr.Read())
            {
                fila++;
                int renglon = dgvGrid1.Rows.Add();
                dgvGrid1.Rows[renglon].Cells["Caja"].Value = Convert.ToString(dr["NOMBRE"]).Trim();
                dgvGrid1.Rows[renglon].Cells["Fecha"].Value = Convert.ToString(dr["FECHA"]).Trim();
                dgvGrid1.Rows[renglon].Cells["Codigo"].Value = Convert.ToString(dr["CODIGO"]).Trim();
                dgvGrid1.Rows[renglon].Cells["Producto"].Value = Convert.ToString(dr["DESCRIP"]).Trim();
                dgvGrid1.Rows[renglon].Cells["Cantidad"].Value = 0;
                dgvGrid1.Rows[renglon].Cells["Precio"].Value = dr["MONTOFINAL"] == DBNull.Value ? 0 : Convert.ToDouble(dr["MONTOFINAL"]);
                prec = Convert.ToDouble(dr["MONTOFINAL"]);
                cant = dgvGrid1.Rows[renglon].Cells["Cantidad"].Value.GetHashCode();
                tot = cant * prec;
                dgvGrid1.Rows[fila - 1].Cells["Total"].Value = tot;
                totd = totd + tot;
            }
            dr.Close();
            txtMontoNota.Text = totd.ToString("N0");
            dgvGrid1.CurrentCell = dgvGrid1.CurrentRow.Cells[5];
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvGrid1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrid1.Rows.Count > 0)
            {
                
                if (dgvGrid1.CurrentCell.ColumnIndex == 5)
                {
                    prec = Convert.ToDouble(dgvGrid1.Rows[dgvGrid1.CurrentRow.Index].Cells[6].Value);
                    cant = Convert.ToDouble(dgvGrid1.Rows[dgvGrid1.CurrentRow.Index].Cells[5].Value);

                    string cod  = Convert.ToString(dgvGrid1.Rows[dgvGrid1.CurrentRow.Index].Cells[0].Value);
                    comsql1 = "SELECT TOP 1 CANTIDAD-CANTAJU CANTIDAD FROM MFACTURAS WHERE codigo = '"+cod+"' AND NUMERO='" + ticketsEmitidos.vnum + "' ";
                    com = new SqlCommand(comsql1, Form1.cn);
                    com.ExecuteNonQuery();
                    dr = com.ExecuteReader();
                    double canto = 0;
                    while (dr.Read())
                    {
                        canto = Convert.ToDouble(dr["CANTIDAD"]);
                    }
                    dr.Close();
                    if (canto < cant ) 
                    { 
                        cant = canto; 
                        dgvGrid1.Rows[dgvGrid1.CurrentRow.Index].Cells[5].Value = cant; 
                    }
                    tot = cant * prec;
                    dgvGrid1.Rows[dgvGrid1.CurrentRow.Index].Cells[7].Value = tot;
                }
            }

            totd = 0;
            foreach (DataGridViewRow row in dgvGrid1.Rows)
            {
                if (row.Cells["Codigo"].Value != null && row.Cells["Cantidad"].Value != null && row.Cells["Precio"].Value != null)
                {
                    prec = Convert.ToInt32(row.Cells["Precio"].Value.ToString());
                    cant = Convert.ToInt32(row.Cells["Cantidad"].Value.ToString());
                    tot = cant * prec;
                    totd += tot;
                }
            }
            txtMontoNota.Text = totd.ToString("N0");
        }

        private void devoluciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (totd > 0)
            {
                cierradev();
            }
        }

        private void cierradev()
        {
            //string rec = "";
            //string num = "";
            //com = new SqlCommand("SELECT MAX(convert(int, RECIBO))+1 REXP FROM RECIBOS WHERE TIPO=1", Form1.cn);
            //com.ExecuteNonQuery();
            //dr = com.ExecuteReader();
            //while (dr.Read())
            //{
            //    rec = Convert.ToString(dr["REXP"]);
            //}
            //dr.Close();

            ////FACTURAS
            //com = new SqlCommand("SELECT MAX(convert(int, NUMERO))+1 REXP FROM FACTURAS", Form1.cn);
            //com.ExecuteNonQuery();
            //dr = com.ExecuteReader();
            //while (dr.Read())
            //{
            //    num = Convert.ToString(dr["REXP"]);
            //}
            //dr.Close();

            ////calculaBoleta();

            //string nom = Form1.nombre.Trim();
            //string con = "CANCELACION DE FATURA ";

            //string sqlcom1 = "INSERT INTO RECIBOS (CODIGO,RECIBO,FECHA,NOMBRE,CONCEPTO,IVA,CAJA,MONTO,NUMERO,RIF,DIRECCION,TELEFONOS,TIPO,EFECTIVO,DEBITO,CREDITO,OTROS,VUELTO) ";
            //string sqlcom2 = "VALUES ('CF','" + rec + "', '" + DateTime.Now + "','" + nom + "','" + con + "'," + 19 + ",'" + iniciarSesion.ucaja + "',";
            //string sqlcom3 = Form1.totf + ",'" + num + "','" + Form1.rut + "','" + Form1.direccion + "','" + Form1.telefono + "'," + 1 + "," + te + "," + td + "," + tc + "," + tc + "," + (tp - Form1.totf) + ") ";

            //string sqlcom = sqlcom1 + sqlcom2 + sqlcom3;

            //com = new SqlCommand(sqlcom, Form1.cn);
            //com.ExecuteNonQuery();

            //int des;
            //DateTime mfec = DateTime.Now;
            //des = Form1.totp - Form1.totf;

            ////FACTURA
            //sqlcom1 = "INSERT INTO FACTURAS (MARCA,NUMERO,CODIGO,FECHA,MONTO,DESCUENTO,ABONO,IVA,IMPUESTO,CAJAPERTUR,RECIBO,STATUS) ";
            //sqlcom2 = "VALUES ('GEMINIS','" + num + "','CONTADO','" + DateTime.Now + "'," + Form1.tots + "," + des + "," + tp + "," + 19 + ",";
            //sqlcom3 = Form1.toti + ",'" + iniciarSesion.ucaja + "', '" + rec + "'," + 2 + ") ";

            //sqlcom = sqlcom1 + sqlcom2 + sqlcom3;

            //com = new SqlCommand(sqlcom, Form1.cn);
            //com.ExecuteNonQuery();

            ////MFACTURAS
            //Form1 FRM1 = Owner as Form1;
            //int mfila = 0;
            //string mcod, mnom, mnum, mgru = "";
            //double mcan, msto, mofe, mtot, mtpr, mmon, mcid = 0;
            //double mcos = 0;
            //double mp1 = 0;
            //double mp2 = 0;
            //double mdes = 0;
            //double mpre, mpr1, mpsi;

            //foreach (DataGridViewRow row in FRM1.dgvGrid1.Rows)
            //{
            //    if (row.Cells["CODIGO1"].Value != null)
            //    {
            //        mfila += 1;
            //        mcod = row.Cells["CODIGO1"].Value.ToString();
            //        mnom = row.Cells["PRODUCTO1"].Value.ToString();
            //        msto = row.Cells["STOCK1"].Value.GetHashCode();
            //        mcan = row.Cells["CANTIDAD1"].Value.GetHashCode();
            //        mpre = Convert.ToDouble(row.Cells["PRECIO1"].Value.ToString());
            //        mpr1 = mpre;
            //        mofe = Convert.ToInt32(row.Cells["OFERTA1"].Value.ToString());
            //        if (mofe > 0 && mcan > 1)
            //        {
            //            mpre = mofe;
            //        }
            //        mtot = mcan * mpre;
            //        mtpr = mcan * mpr1;
            //        mmon = mtot;
            //        mfec = DateTime.Now;
            //        mnum = num;
            //        mpsi = mpre / 1.19;

            //        com = new SqlCommand("SELECT E.CANTIDAD STOCK,I.COSTO,I.PRECIO1,I.PRECIO2,I.GRUPO,E.CODID FROM INVENTARIO I LEFT JOIN EXISTENCIA E ON E.CODIGO=I.CODIGO WHERE I.CODIGO = '" + mcod + "' ", Form1.cn);
            //        com.ExecuteNonQuery();
            //        dr = com.ExecuteReader();
            //        while (dr.Read())
            //        {
            //            mcos = Convert.ToDouble(dr["COSTO"]);
            //            mp1 = Convert.ToDouble(dr["PRECIO1"]);
            //            mp2 = dr["PRECIO2"] == DBNull.Value ? 0 : Convert.ToDouble(dr["PRECIO2"]);
            //            msto = Convert.ToInt32(dr["STOCK"]);
            //            mgru = Convert.ToString(dr["GRUPO"]);
            //            mcid = Convert.ToInt32(dr["CODID"]);

            //        }
            //        dr.Close();

            //        if (mcan > 1 && mp2 > 0) { mdes = (mp1 - mp2); }

            //        sqlcom1 = "INSERT INTO MFACTURAS (NUMERO,FECHA,POSI,IVA3,CODIGO,DESCRIP,COSTO,MONTO,CANTIDAD,GRUPO,IVA,CACTUAL,CODID,MONTOFINAL,PRECIOA,ALMACEN) ";
            //        sqlcom2 = "VALUES ('" + num + "','" + DateTime.Now + "'," + mfila + "," + mdes + ",'" + mcod + "','" + mnom + "'," + mcos + "," + mpsi + ",";
            //        sqlcom3 = mcan + ",'" + mgru + "', " + 1 + "," + msto + "," + mcid + "," + mtot + "," + mp1 + ",'" + Form1.alma + "') ";
            //        sqlcom = sqlcom1 + sqlcom2 + sqlcom3;
            //        com = new SqlCommand(sqlcom, Form1.cn);
            //        com.ExecuteNonQuery();
            //    }
            //}
            //// IMPRIME TICKECT
            //FRM1.dgvGrid1.Rows.Clear();
            //this.Close();
        }

    }
}

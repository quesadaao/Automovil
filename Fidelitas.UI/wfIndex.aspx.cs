using Fidelitas.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fidelitas.UI
{
    public partial class wfIndex : System.Web.UI.Page
    {
        #region Variables
        Automovil automovil = new Automovil();
        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                BindData();
            } else {

            }
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues(1);
                BS.Mantenimiento._Instancia.Insert(automovil);
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            GetValues(2);
            BS.Mantenimiento._Instancia.Update(automovil);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            GetValues(0);
            BS.Mantenimiento._Instancia.Delete(automovil);
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            BindData();
        }

        #endregion

        #region Methods

        public void GetValues(int flag) {
            // Delete 
            if (flag == 0)
            {
                automovil.iID = Convert.ToInt32(txtID.Text);
            }
            else if (flag == 1) {
                automovil.iID = Convert.ToInt32(txtID.Text);
                automovil.vNombre = txtNombre.Text;
                automovil.iEstilo = ddlEstilo.SelectedIndex;
                automovil.iCilindraje = Convert.ToInt32(txtCilindraje.Text);
                automovil.iCosto = Convert.ToInt32(txtCosto.Text);
                automovil.vTransmision = ddlTransmision.Text;
                automovil.iCantidadPuertas = Convert.ToInt32(txtPuertas.Text);
                automovil.iAno = Convert.ToInt32(txtAno.Text);
                automovil.vNombreMarca = txtMarca.Text;
            }
            else if (flag == 2) {
                automovil.vNombre = txtNombre.Text;
                automovil.iEstilo = ddlEstilo.SelectedIndex;
                automovil.iCilindraje = Convert.ToInt32(txtCilindraje.Text);
                automovil.iCosto = Convert.ToInt32(txtCosto.Text);
                automovil.vTransmision = ddlTransmision.Text;
                automovil.iCantidadPuertas = Convert.ToInt32(txtPuertas.Text);
                automovil.iAno = Convert.ToInt32(txtAno.Text);
                automovil.vNombreMarca = txtMarca.Text;
            }
            

        }

        public void BindData() {
            Session["gridview"] = BS.Mantenimiento._Instancia.GetAll();
            gridview.DataSource = Session["gridview"];
            gridview.DataBind();
        }

        #endregion

       
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_RRHH
{
    public partial class frm_mantenimientoExamen : Form
    {
        public frm_mantenimientoExamen()
        {
            InitializeComponent();
            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();
            /// Marco Alejandro Monroy*/
            /*Prueba con navegador*/
            string[] alias = { "ID_equipo", "nombre equipo", "entrenador", "id_deporte","torneos_ganados", "estado"};
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#B4D2F0"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("equipo");
            navegador1.ObtenerIdAplicacion("16002");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Equipo");


           // navegador1.AsignarComboConTabla("tbl_empleados", "pk_clave", "empleados_nombre", 1);

        }
    }
}

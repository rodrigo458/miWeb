using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LP2SoftModel; //No olvidar agregar este namespace del otro proyecto y agregar la Referencia en VS

namespace LP2SoftController.LP2SoftDAO
{
    public interface AreaDAO
    {
        int insertar(Area area);
        int actualizar(Area area);
        int eliminar(int idArea);
        BindingList<Area> listar();
    }
}

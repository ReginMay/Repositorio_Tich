using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDestatus
{
    internal class CRUDAlum
    {

        List<AlumnosStatus> _listStatus = new List<AlumnosStatus>();
       
        public List<AlumnosStatus> consultarTodos()
        {
            return _listStatus;

        }

        public AlumnosStatus consultarUno(int id)
        {

            AlumnosStatus aSt = _listStatus.Find(stt => stt.Id == id);

            return aSt;
        }

        public void Agregar(AlumnosStatus stat)
        {
            //AlumnosStatus aSt = new AlumnosStatus();
            //aSt.Id = stat.Id;
            //aSt.clave = stat.clave;
            //aSt.nombre = stat.nombre;
            
            _listStatus.Add(stat);
        }

        public void Actualizar(AlumnosStatus stat)
        {
            AlumnosStatus aSt = _listStatus.Find(stt => stt.Id == stat.Id);
            aSt.Id = stat.Id;
            aSt.clave = stat.clave;
            aSt.nombre = stat.nombre;
        }
        public void Eliminar(int id)
        {
            AlumnosStatus aSt = _listStatus.Find(stt => stt.Id == id);
            _listStatus.Remove(aSt);

        }


    }
}

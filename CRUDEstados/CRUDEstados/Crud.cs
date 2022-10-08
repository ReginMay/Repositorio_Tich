using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstados
{
    internal class Crud
    {
        Dictionary<int, Estado> _DiccionariyEstados = new Dictionary<int, Estado>();
        Estado _ObjeEstado = new Estado();

        public Dictionary<int, Estado> consultarTodos()
        {
            return _DiccionariyEstados;

        }
        public Estado consultarUno(int id)
        {
           
            if (_DiccionariyEstados.ContainsKey(id))
            {
                _ObjeEstado=_DiccionariyEstados[id];
            }

            return _ObjeEstado;
        }
        public void Agregar(Estado estado)
        {
            _DiccionariyEstados.Add(estado.Id,estado);
        }
        public void Actualizar(Estado estado)
        {
            if (_DiccionariyEstados.ContainsKey(estado.Id))
            {
                //_ObjeEstado = _DiccionariyEstados[estado.Id];
                //  _ObjeEstado.nombre = estado.nombre;
                _DiccionariyEstados[estado.Id] = estado;
              
            }
      
        }
        public void Eliminar(int id)
        {
            _DiccionariyEstados.Remove(id);

        }

    }
}

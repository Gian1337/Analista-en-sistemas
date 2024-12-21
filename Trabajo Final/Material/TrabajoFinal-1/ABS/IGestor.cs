using System.Collections.Generic;

namespace ABS
{
    public interface IGestor<T> where T : IEntidad
    {
        List<T> ListarTodo();
        bool Guardar(T obj);
        bool Borrar(T obj);
    }
}

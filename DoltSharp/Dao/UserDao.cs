using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoltSharp.Models;

namespace DoltSharp.Dao
{
    internal class UserDao
    {
        private List<User> usuarios;

        public UserDao()
        {
            usuarios = new List<User>();
        }

        public List<User> ObtenerUsuarios()
        {
            return usuarios;
        }

        public void AgregarUsuario(User usuario)
        {
            usuarios.Add(usuario);
        }

        public User BuscarUsuarioPorId(int id)
        {
            return usuarios.Find(user => user.Id == id);
        }

        public void EliminarUsuarioPorId(int id)
        {
            var usuario = BuscarUsuarioPorId(id);
            if (usuario != null)
            {
                usuarios.Remove(usuario);
            }
        }

        public void ActualizarUsuario(int id, User usuarioActualizado)
        {
            int index = usuarios.FindIndex(user => user.Id == id);

            if (index != -1)
            {
                usuarios[index] = usuarioActualizado;
            }
        }
    }
}


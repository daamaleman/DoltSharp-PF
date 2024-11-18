//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DoltSharp.Dao
//{
//    internal class UserDao
//    {
//        private List<UserDao> usuarios;

//        public UserDao()
//        {
//            usuarios = new List<UserDao>();
//        }

//        public List<UserDao> ObtenerUsuarios()
//        {
//            return usuarios;
//        }

//        public void AgregarUsuario(UserDao usuario)
//        {
//            usuarios.Add(usuario);
//        }

//        public UserDao BuscarUsuarioPorId(int id)
//        {
//            return usuarios.Find(user => user.ID == id);
//        }

//        public void EliminarUsuarioPorId(int id)
//        {
//            var usuario = BuscarUsuarioPorId(id);
//            if (usuario != null)
//            {
//                usuarios.Remove(usuario);
//            }
//        }

//        public void ActualizarUsuario(int id, UserDao usuarioActualizado)
//        {
//            int index = usuarios.FindIndex(user => user.ID == id);

//            if (index != -1)
//            {
//                usuarios[index] = usuarioActualizado;
//            }
//        }
//    }
//}


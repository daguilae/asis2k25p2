using System.Data;
using Capa_Modelo_Seguridad;
/* Brandon Alexander Hernandez Salguero
 * 0901-22-9663
 */

namespace Capa_Controlador_Seguridad
{
    /// <summary>
    /// Controlador para la asignación de perfil a usuario. Expone métodos para obtener usuarios, perfiles
    /// y para insertar una relación usuario-perfil, devolviendo mensajes de error personalizados si corresponde.
    /// </summary>
    public class Cls_asignacion_perfil_usuarioControlador
    {
        Cls_asignacion_perfil_usuarioDAO DAO = new Cls_asignacion_perfil_usuarioDAO();

        /// <summary>
        /// Obtiene la lista de usuarios (para llenar combo en la vista).
        /// </summary>
        public DataTable datObtenerUsuarios()
        {
            return DAO.datObtenerUsuarios();
        }

        /// <summary>
        /// Obtiene la lista de perfiles (para llenar combo en la vista).
        /// </summary>
        public DataTable datObtenerPerfiles()
        {
            return DAO.datObtenerPerfiles();
        }

        /// <summary>
        /// Inserta la relación usuario-perfil. Devuelve true si se pudo insertar,
        /// false si hubo error. El mensaje de error se entrega en el parámetro out.
        /// </summary>
        /// <param name="id_usuario">ID del usuario a asignar</param>
        /// <param name="id_perfil">ID del perfil a asignar</param>
        /// <param name="mensajeError">Mensaje de error si ocurre (por ejemplo, si ya existe la relación)</param>
        /// <returns>True si se insertó correctamente, False si hubo error</returns>
        public bool bInsertar(int id_usuario, int id_perfil, out string mensajeError)
        {
            Cls_asignacion_perfil_usuario nuevaRelacion = new Cls_asignacion_perfil_usuario
            {
                Fk_Id_Usuario = id_usuario,
                Fk_Id_Perfil = id_perfil,
            };

            // Llama al método DAO que maneja el error y retorna el mensaje personalizado
            return DAO.bInsertar(nuevaRelacion, out mensajeError);
        }
    }
}